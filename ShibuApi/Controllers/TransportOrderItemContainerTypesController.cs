using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using ShipbuApi.Models.Data;
using ShipbuData;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportOrderItemContainerTypesController : ControllerBase
    {
        private readonly AppDbContext context;

        public TransportOrderItemContainerTypesController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {
            var query = context.TransportOrderItemContainerTypes;

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "DisplayOrder";

            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await context.TransportOrderItemContainerTypes.FindAsync(id);

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportOrderItemContainerTypeViewModel model)
        {
            var item = new TransportOrderItemContainerType
            {
                Enabled = model.Enabled,
                NameTr = model.NameTr,
                NameEn = model.NameEn,
                DisplayOrder = (context.TransportOrderItemContainerTypes.OrderByDescending(p => p.DisplayOrder).FirstOrDefault()?.DisplayOrder ?? 0) + 1,
            };
            context.TransportOrderItemContainerTypes.Add(item);
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = item });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli birden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, TransportOrderItemContainerTypeViewModel model)
        {
            var item = await context.TransportOrderItemContainerTypes.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            item.Enabled = model.Enabled;
            item.NameTr = model.NameTr;
            item.NameEn = model.NameEn;
            item.DisplayOrder = model.DisplayOrder;
            context.TransportOrderItemContainerTypes.Update(item);
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = item });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli birden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpGet("reorder/{fromId:guid}/{toId:guid}")]
        public async Task<IActionResult> GetReorder(Guid fromId, Guid toId)
        {
            var subject = await context.TransportOrderItemContainerTypes.FindAsync(fromId);
            var target = await context.TransportOrderItemContainerTypes.FindAsync(toId);

            if (subject is null || target is null)
                return BadRequest($"Bulunamadı!");

            if (subject.DisplayOrder > target.DisplayOrder)
                context
                    .TransportOrderItemContainerTypes
                    .OrderBy(p => p.DisplayOrder)
                    .Where(p => p.DisplayOrder >= target.DisplayOrder && p.DisplayOrder < subject.DisplayOrder)
                    .ExecuteUpdate(p => p.SetProperty(q => q.DisplayOrder, r => r.DisplayOrder + 1));
            else
                context
                    .TransportOrderItemContainerTypes
                    .OrderBy(p => p.DisplayOrder)
                    .Where(p => p.DisplayOrder <= target.DisplayOrder && p.DisplayOrder > subject.DisplayOrder)
                    .ExecuteUpdate(p => p.SetProperty(q => q.DisplayOrder, r => r.DisplayOrder - 1));

            subject.DisplayOrder = target.DisplayOrder;
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = null });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli birden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var item = await context.TransportOrderItemContainerTypes.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            context.TransportOrderItemContainerTypes.Remove(item);
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = item });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Kayıt bir yada daha fazla kayıt ile ilişkili olduğu için işlem yapılamıyor!" });
            }
        }


    }
}
