using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuData;
using System.Security.Claims;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportOrdersController : ControllerBase
    {

        private readonly AppDbContext context;

        public TransportOrdersController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {

            var query = context
                .TransportOrders
                .Include(p => p.User)
                .Include(p => p.Origin)
                .Include(p => p.District)
                .ThenInclude(p => p.Region)
                .AsNoTracking()
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
                    p.TrackingNumber,
                    p.User!.UserName,
                    UserGivenName = p.User.Name,
                    p.UserId
                });

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;

            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {

            var query = await context
                .TransportOrders
                .Include(p => p.User)
                .Include(p=>p.TransportOrderItems)
                .ThenInclude(p=>p.TransportOrderItemFeatures)
                .Include(p => p.Origin)
                .Include(p => p.District)
                .ThenInclude(p => p.Region)
                .AsNoTracking()
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
                    p.TrackingNumber,
                    p.User!.UserName,
                    UserGivenName = p.User.Name,
                    p.UserId,
                    TransportFee = p.TransportFee!.Value,
                    TransportMethod = p.TransportFee!.Method!.NameTr,
                    TransportETA = p.TransportFee.Method.TransportRegionMethods.Select(q=> new { q.RegionId, ETA = q.ETAMin + " - " + q.ETAMax }).Single(q=>q.RegionId == p.District.RegionId).ETA,
                    TransportOrderItemsPackage = p.TransportOrderItems.OfType<TransportOrderItemPackage>().Select(q => new
                    {
                        q.Id,
                        q.Image,
                        q.Height,
                        q.Length,
                        q.Products,
                        q.Quantity,
                        q.Weight,
                        q.Width,
                        q.Content,
                        q.TransportOrderItemFeatures
                    }),
                    TransportOrderItemsPallet = p.TransportOrderItems.OfType<TransportOrderItemPallet>().Select(q => new
                    {
                        q.Id,
                        q.Image,
                        q.Height,
                        q.Length,
                        q.Quantity,
                        q.Weight,
                        q.Width,
                        q.Content,
                        q.TransportOrderItemFeatures
                    }),
                    TransportOrderItemsContainer = p.TransportOrderItems.OfType<TransportOrderItemContainer>().Select(q => new
                    {
                        q.Id,
                        q.Image,
                        q.Quantity,
                        q.Weight,
                        q.TransportOrderItemContainerType,
                        q.TransportOrderItemFeatures
                    }),

                })
                .SingleOrDefaultAsync(p=>p.Id == id);


            return Ok(query);
        }


        [HttpGet("updateorderprice/{id}/{newPrice:decimal}")]
        public async Task<IActionResult> UpdateOrderPrice(Guid id, decimal newPrice)
        {
            var order = await context.TransportOrders.FindAsync(id);
            order.Status = TransportOrderStatus.Payment;
            order.Price = newPrice;
            context.TransportOrders.Update(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("updateordershipping/{id}/{shippingNumber}/{trackingNumber}")]
        public async Task<IActionResult> UpdateOrderShipping(Guid id,string shippingNumber, string trackingNumber)
        {
            var order = await context.TransportOrders.FindAsync(id);
            order.Status = TransportOrderStatus.Shipped;
            order.ShippingNumber = shippingNumber;
            order.TrackingNumber = trackingNumber;
            context.TransportOrders.Update(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("paymentorder/{id}")]
        public async Task<IActionResult> UpdatePaymentOrder(Guid id)
        {
            var order = await context.TransportOrders.FindAsync(id);
            order.Status = TransportOrderStatus.Accepted;
            context.TransportOrders.Update(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("deliveredorder/{id}")]
        public async Task<IActionResult> UpdateDeliveredOrder(Guid id)
        {
            var order = await context.TransportOrders.FindAsync(id);
            order.Status = TransportOrderStatus.Delivered;
            context.TransportOrders.Update(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("cancelorder/{id}")]
        public async Task<IActionResult> UpdateCancelOrder(Guid id)
        {
            var order = await context.TransportOrders.FindAsync(id);
            order.Status = TransportOrderStatus.Cancelled;
            context.TransportOrders.Update(order);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
