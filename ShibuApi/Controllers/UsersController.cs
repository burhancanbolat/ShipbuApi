using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuApi.Models;
using ShipbuApi.Models.Data;
using ShipbuData;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        private readonly AppDbContext context;
        private readonly UserManager<User> userManager;

        public UsersController(
            AppDbContext context,
            UserManager<User> userManager

            )
        {
            this.context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {

            var query = userManager
                .Users
                .AsNoTracking()
                .Select(p=> new
                {
                    p.Id,
                    p.Name,
                    p.UserName,
                    p.DateCreated,
                    p.Email,
                    p.Enabled,
                    p.PhoneNumber,
                })
                .OrderBy(p => p.Name);


            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "Name";

            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await context.Users.FindAsync(id));


        [HttpGet("banuser/{id}")]
        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> BanUser(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            user.Enabled = false;
            context.Users.Update(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("unbanuser/{id}")]
        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> UnbanUser(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            user.Enabled = true;
            context.Users.Update(user);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("getadminusers")]
        [Authorize(Roles = "Administrators")]
        public async Task<IActionResult> GetAdminUsers()
        {
           
            var usersInRole = await userManager.GetUsersInRoleAsync("Administrators");

            
            var userModels = usersInRole.Select(u => new UserModel
            {
                Id = u.Id,
                UserName = u.UserName,

               
            }).ToList();

            return Ok(userModels);
        }

    }
}
