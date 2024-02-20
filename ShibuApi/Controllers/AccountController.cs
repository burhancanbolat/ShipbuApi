using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NETCore.MailKit.Core;
using ShipbuApi;
using ShipbuApi.Models;
using ShipbuData;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Shipbu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;
        private readonly IEmailService emailService;
        private readonly AppDbContext context;

        public AccountController(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IConfiguration configuration,
            IWebHostEnvironment env,
            IEmailService emailService,
            AppDbContext context
            )
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.configuration = configuration;
            this.env = env;
            this.emailService = emailService;
            this.context = context;
        }

        [NonAction]
        private async Task<string> GenerateTokenForUser(User user)
        {
            var refreshToken = Guid.NewGuid();
            user.RefreshToken = refreshToken;
            await userManager.UpdateAsync(user);
            var roles = await userManager.GetRolesAsync(user);

            var claims = new[]{
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(ClaimTypes.Name, user.UserName!),
                            new Claim(ClaimTypes.GivenName, user.Name),
                            new Claim(ClaimTypes.Email, user.UserName!),
                            new Claim("dateCreated", user.DateCreated.ToString()),
                            new Claim("refreshToken",refreshToken.ToString()),
                    }.ToList();

            claims.AddRange(roles.Select(p => new Claim(ClaimTypes.Role, p)));

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("Security:Secret")!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(configuration.GetValue<TimeSpan>("Security:TokenLifeTime")),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }

        [HttpPost("token")]
        public async Task<IActionResult> Token(TokenViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
            if (result.Succeeded)
            {
                var user = await userManager.FindByNameAsync(model.UserName);

                if (user!.Enabled)
                {
                    var token = await GenerateTokenForUser(user);
                    return Ok(new { token, result });
                }
            }
            return Ok(new { result });
        }

        [HttpPost("refreshtoken")]
        public async Task<IActionResult> RefreshToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;

            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.GetValue<string>("Security:Secret")!)),
                ValidateLifetime = false,
                ValidateAudience = false,
                ValidateIssuer = false,
                ClockSkew = TimeSpan.Zero
            }, out validatedToken);

            if (validatedToken == null)
                return BadRequest();

            var user = await userManager.Users.SingleOrDefaultAsync(u => u.RefreshToken.ToString() == token);

            return Ok(new { token = await GenerateTokenForUser(user) });
        }

        [HttpGet("signout")]
        [Authorize]
        public async Task<IActionResult> Revoke()
        {

            var user = await userManager.GetUserAsync(User);
            user!.RefreshToken = null;
            await userManager.UpdateAsync(user);
            return Ok();
        }

        [AllowAnonymous, HttpPost("addpassword")]
        public async Task<IActionResult> AddPassword(AddPasswordViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user is not null && await userManager.VerifyUserTokenAsync(user, "Email", "AddPassword", model.Token))
            {
                var result = await userManager.AddPasswordAsync(user, model.NewPassword);
                return result.Succeeded ? Ok() : BadRequest(result);
            }
            else
                return BadRequest(model);


        }

        [AllowAnonymous, HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user is null)
                return BadRequest(model);
            var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            return result.Succeeded ? Ok() : BadRequest(result);
        }

        [HttpGet("profile")]
        [Authorize]
        public async Task<IActionResult> GetProfile()
        {
            var userId = Guid.Parse(User.FindFirstValue("id")!);

            var model = await context
                .Users
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Email,
                    p.DateCreated,
                })
               .SingleOrDefaultAsync(p => p.Id == userId);
            if (model is null)
                return BadRequest("No user profile!");
            return Ok(model);
        }

        [HttpPost("updateprofile")]
        [Authorize]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileViewModel model)
        {
            var user = await userManager.FindByIdAsync(User.FindFirstValue("id")!);
            if (user is not null)
            {
                user.Name = model.Name;

                context.Users.Update(user);
                await context.SaveChangesAsync();
            }

            return Ok(user);
        }

        [HttpPost("changepassword")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordViewModel model)
        {
            var user = await userManager.FindByIdAsync(User.FindFirstValue("id")!);
            if (user is not null)
                if (!string.IsNullOrEmpty(model.NewPassword))
                    await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

            return Ok();
        }

        [HttpGet("forgotpassword/{userName}")]
        public async Task<IActionResult> ForgotPassword(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
                return BadRequest(userName);
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var template = string.Format(System.IO.File.ReadAllText(Path.Combine(env.WebRootPath, "Templates", "ResetPassword.html")),
                user!.Name,
                configuration["Title"],
                configuration["HostDomain"],
                token
                );
            var userEmail = user.UserName;
            emailService.Send(userEmail, $"{configuration["Title"]} Parola Yenileme Mesajı", template, isHtml: true);

            return Ok(new { id = user.Id, userName = user.UserName });
        }

        [HttpPost("renewpassword")]
        public async Task<IActionResult> RenewPassword([FromBody] RenewPasswordViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user is null)
                return BadRequest(model.UserName);
            var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterMember([FromBody] RegisterMemberViewModel model)
        {
            var user = new User
            {
                Name = model.Name,
                Email = model.UserName,
                UserName = model.UserName,
                DateCreated = DateTime.UtcNow,
                EmailConfirmed = false,
                Enabled = true
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var template = string.Format(
                    System.IO.File.ReadAllText(Path.Combine(env.WebRootPath, "Templates", "User.html")),
                    user.Name,
                    configuration["Title"],
                    token
                    );
                await userManager.AddToRoleAsync(user, "Members");
                emailService.Send(user.UserName, $"{configuration["Title"]} E-Posta Doğrulama Mesajı", template, isHtml: true);
            }
            return Ok(result);
        }

        [HttpGet("confirmemail/{userName}/{token}")]
        public async Task<IActionResult> ConfirmMemberEMail(string userName, string token)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
                return BadRequest(userName);
            var result = await userManager.ConfirmEmailAsync(user, token);
            return Ok(result);
        }

        [HttpPost("transportoffers")]
        public async Task<IActionResult> GetTransportOffers(TransportOrderViewModel model)
        {

            var transportVolumeWeight = configuration.GetValue<int>("TransportVolumeWeight");
            var totalWeight = (decimal)(model.Items.Select(p => new { Desi = ((p.Width ?? 0 * p.Height ?? 0 * p.Length ?? 0) / transportVolumeWeight) * p.Quantity, Weight = p.Amount }).Sum(p => Math.Max(p.Desi, p.Weight)));
            var features = model.Items.SelectMany(p => p.Features).GroupBy(p => p.Id).Select(p => new { id = p.Key, fee = p.First().Fee, nameTr = p.First().NameTr, nameEn = p.First().NameEn, amount = p.First().Fee * totalWeight }).ToList();
            var featureAmount = features.Sum(p => p.fee) * totalWeight;
            var result = await context
                .TransportFees
                .AsNoTracking()
                .Where(p => p.DistrictId == model.District.Id && p.MinWeight < totalWeight && (p.MaxWeight >= totalWeight || p.MaxWeight == null))
                .Select(p => new
                {
                    p.Id,
                    p.Value,
                    MethodNameTr = p.Method!.NameTr,
                    MethodNameEn = p.Method!.NameEn,
                    DistrictNameTr = p.District!.NameTr,
                    DistrictNameEn = p.District!.NameEn,
                    TransportPrice = (p.Value * totalWeight),
                    FeaturePrice = featureAmount,
                    Price = (p.Value * totalWeight) + featureAmount,
                    Features = features,
                    p.MinWeight,
                    p.MethodId,
                    EtaMin = p.Method.TransportRegionMethods.Single(q => q.RegionId == model.Destination).ETAMin,
                    EtaMax = p.Method.TransportRegionMethods.Single(q => q.RegionId == model.Destination).ETAMax,
                    EtaDate = DateTime.Today.AddDays(p.Method.TransportRegionMethods.Single(q => q.RegionId == model.Destination).ETAMin ?? 1)
                })
                .OrderBy(p => p.Price)
                .ToListAsync();
            return Ok(result);
        }

        [HttpPost("transportorder")]
        [Authorize]
        public async Task<IActionResult> SetTransportOrder(TransportOrderViewModel model)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var order = new TransportOrder
            {
                Address = model.Address,
                Date = DateTime.UtcNow,
                TransportFeeId = model.TransportFeeId,
                DestinationId = model.District.Id,
                Price = model.Price,
                Name = model.Name,
                OriginId = model.Origin,
                PhoneNumber = model.PhoneNumber,
                UserId = userId,
                Status = TransportOrderStatus.Offer,
                TransportOrderItems = new List<TransportOrderItem>()
            };

            model.Items.ForEach(p =>
            {
                var features = context.TransportOrderItemFeatures.Where(q => p.Features.Select(q => q.Id).Any(r => r == q.Id)).ToList();
                switch (p.Type.Id)
                {
                    case 0:
                        order.TransportOrderItems.Add(new TransportOrderItemPackage
                        {
                            Content = p.Contents,
                            Height = p.Height!.Value,
                            Image = p.Image,
                            Length = p.Length!.Value,
                            Products = p.Products!.Value,
                            Quantity = p.Quantity,
                            Weight = p.Weight,
                            Width = p.Width!.Value,
                            TransportOrderItemFeatures = features
                        });
                        break;
                    case 1:
                        order.TransportOrderItems.Add(new TransportOrderItemPallet
                        {
                            Content = p.Contents,
                            Height = 80,
                            Image = p.Image,
                            Length = p.Length!.Value,
                            Quantity = p.Quantity,
                            Weight = p.Weight,
                            Width = 120,
                            TransportOrderItemFeatures = features
                        });
                        break;
                    case 2:
                        order.TransportOrderItems.Add(new TransportOrderItemContainer
                        {
                            Image = p.Image,
                            Quantity = p.Quantity,
                            Weight = p.Weight,
                            TransportOrderItemContainerTypeId = p.ContainerType!.Id,
                            TransportOrderItemFeatures = features
                        });
                        break;
                }
            });

            context.TransportOrders.Add(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("orders")]
        [Authorize]
        public async Task<IActionResult> GetTransportOrders(DataSourceLoadOptions options)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var query = context
                .TransportOrders
                .Include(p => p.Origin)
                .Include(p => p.District)
                .ThenInclude(p => p.Region)
                .AsNoTracking()
                .Where(p => p.UserId == userId)
                .OrderByDescending(p => p.Date)
                .Select(p => new
                {
                    p.Id,
                    Date = p.Date.ToLocalTime(),
                    p.Address,
                    p.PhoneNumber,
                    p.Name,
                    OriginNameTr = p.Origin!.NameTr,
                    OriginNameEn = p.Origin!.NameEn,
                    DestinationRegionNameTr = p.District!.Region!.NameTr,
                    DestinationRegionNameEn = p.District!.Region!.NameEn,
                    DestinationDistrictNameTr = p.District!.NameTr,
                    DestinationDistrictNameEn = p.District!.NameEn,
                    p.District.IsAmazonDepot,
                    p.Price,
                    p.Status,
                    p.ShippingNumber,
                    p.TrackingNumber
                });
            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("payments")]
        [Authorize]
        public async Task<IActionResult> GetPayments(DataSourceLoadOptions options)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var query = context
                .TransportPayments
                .AsNoTracking()
                .Where(p => p.UserId == userId)
                .OrderByDescending(p => p.Date)
                .Select(p => new
                {
                    p.Id,
                    Date = p.Date.ToLocalTime(),
                    p.Amount,
                });
            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpPost("supportmessage")]
        [Authorize]
        public async Task<IActionResult> PostSupportMessages(TransportSupportMessageViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await userManager.FindByIdAsync(userId!);
            var html = System.IO.File.ReadAllText(Path.Combine(env.WebRootPath, "Templates", "SupportMessage.html"));
            var body = string.Format(
                html,
                user!.Name,
                user.UserName,
                model.Subject,
                DateTime.UtcNow.ToLocalTime().ToShortDateString(),
                model.Message
                );
            emailService.Send(
                configuration.GetValue<string>("EMail:UserName"),
                "Shipbu Kullanıcı Destek Talebi Mesajı",
                body,
                isHtml: true);

            return Ok();
        }

        


    }
}
