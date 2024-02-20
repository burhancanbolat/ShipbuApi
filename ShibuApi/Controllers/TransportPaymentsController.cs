using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuApi.Models.Data;
using ShipbuData;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportPaymentsController : ControllerBase
    {

        private readonly AppDbContext context;

        public TransportPaymentsController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {

            var query = context
                .TransportPayments
                .Include(p => p.User)
                .AsNoTracking()
                .OrderByDescending(p => p.Date)
                .Select(p => new
                {
                    p.Id,
                    p.UserId,
                    p.Amount,
                    p.Date
                });


            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "Date";
           
            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportPaymentViewModel model)
        {

            var item = new TransportPayment
            {
                Amount = model.Amount,
                UserId = model.UserId,
                Date = model.Date
            };
            context.TransportPayments.Add(item);
            await context.SaveChangesAsync();
            return Ok(new AppApiResponse { Succeded = true, Data = item });

        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, TransportPaymentViewModel model)
        {
            var item = await context.TransportPayments.FindAsync(id);
            item!.Amount = model.Amount;
            item!.Date = model.Date;
            context.TransportPayments.Update(item);
            await context.SaveChangesAsync();
            return Ok(new AppApiResponse { Succeded = true, Data = item });

        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var item = await context.TransportPayments.FindAsync(id);
            context.TransportPayments.Remove(item!);
            await context.SaveChangesAsync();
            return Ok(new AppApiResponse { Succeded = true, Data = item });
        }

        [HttpGet("userbalance/{id:guid}")]
        public async Task<IActionResult> GetUserBalance(Guid id)
        {
            var paymentsTotal = await context.TransportPayments.Where(p => p.UserId == id).SumAsync(p => p.Amount);
            var ordersTotal = (await context.Users.Include(p=>p.TransportOrders).SingleOrDefaultAsync(p=>p.Id == id))!.TransportOrders.Where(p => p.Status == TransportOrderStatus.Delivered || p.Status == TransportOrderStatus.Shipped).Sum(p => p.Price);
            return Ok(paymentsTotal - ordersTotal);
        }
    }
}
