using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuData;
using System.Globalization;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportDashboardController : ControllerBase
    {
        private readonly AppDbContext context;

        public TransportDashboardController(
                AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(new
            {
                Users = await context.Users.CountAsync(),
                Orders = await context.TransportOrders.AsNoTracking().CountAsync(p => p.Status == TransportOrderStatus.Offer),
                DeliveredOrders = await context.TransportOrders.AsNoTracking().CountAsync(p => p.Status == TransportOrderStatus.Shipped),
                CancelledOrders = await context.TransportOrders.AsNoTracking().CountAsync(p => p.Status == TransportOrderStatus.Cancelled),
                TotalNewOrderAmount = await context.TransportOrders.AsNoTracking().Where(p => p.Status == TransportOrderStatus.Offer).SumAsync(p => p.Price),
                TotalOrderAmount = await context.TransportOrders.AsNoTracking().Where(p => p.Status == TransportOrderStatus.Shipped || p.Status == TransportOrderStatus.Delivered).SumAsync(p => p.Price),
                LastOrders = await context.TransportOrders.Include(p => p.User).AsNoTracking().Where(p => p.Status == TransportOrderStatus.Offer).Select(p => new { UserGivenName = p.User!.Name, Amount = p.Price, Date = p.Date.ToLocalTime(), Origin = p.Origin!.NameTr, Destination = $"{p.District!.NameTr}/{p.District!.Region!.NameTr}" }).ToListAsync(),
                ChartData = (await context.TransportOrders.AsNoTracking().Where(p => p.Date > DateTime.Today.AddYears(-1)).GroupBy(p => p.Date.Month).Select(p => new { Month = p.Key, Amount = p.Sum(q => q.Price), Total = p.Where(q => q.Status == TransportOrderStatus.Delivered).Sum(q => q.Price), }).Take(10).ToListAsync()).Select(p => new { p.Amount, p.Total, Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(p.Month) }).ToList()
            });
        }
    }
}
