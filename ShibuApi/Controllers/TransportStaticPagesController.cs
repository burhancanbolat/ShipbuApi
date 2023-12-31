using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuApi.Models.Data;
using ShipbuData;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportStaticPagesController : ControllerBase
    {
        private readonly AppDbContext context;

        public TransportStaticPagesController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {
            var query = context.TransportStaticPages;

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "DisplayOrder";
            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await context.TransportStaticPages.FindAsync(id);

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportStaticPageViewModel model)
        {
            var item = new TransportStaticPage
            {
                Enabled = model.Enabled,
                LabelTr = model.LabelTr,
                LabelEn = model.LabelEn,
                ContentTr = model.ContentTr,
                ContentEn = model.ContentEn,
                DisplayOrder = (context.TransportOrderItemContainerTypes.OrderByDescending(p => p.DisplayOrder).FirstOrDefault()?.DisplayOrder ?? 0) + 1,
            };
            context.TransportStaticPages.Add(item);
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = item });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli briden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, TransportStaticPageViewModel model)
        {
            var item = await context.TransportStaticPages.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            item.Enabled = model.Enabled;
            item.LabelTr = model.LabelTr;
            item.LabelEn = model.LabelEn;
            item.ContentTr = model.ContentTr;
            item.ContentEn = model.ContentEn;
            item.DisplayOrder = model.DisplayOrder;
            context.TransportStaticPages.Update(item);
            try
            {
                await context.SaveChangesAsync();
                return Ok(new AppApiResponse { Succeded = true, Data = item });
            }
            catch (DbUpdateException)
            {
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli briden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpGet("reorder/{fromId:guid}/{toId:guid}")]
        public async Task<IActionResult> GetReorder(Guid fromId, Guid toId)
        {
            var subject = await context.TransportStaticPages.FindAsync(fromId);
            var target = await context.TransportStaticPages.FindAsync(toId);

            if (subject is null || target is null)
                return BadRequest($"Bulunamadı!");

            if (subject.DisplayOrder > target.DisplayOrder)
                context
                    .TransportStaticPages
                    .OrderBy(p => p.DisplayOrder)
                    .Where(p => p.DisplayOrder >= target.DisplayOrder && p.DisplayOrder < subject.DisplayOrder)
                    .ExecuteUpdate(p => p.SetProperty(q => q.DisplayOrder, r => r.DisplayOrder + 1));
            else
                context
                    .TransportStaticPages
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
                return Ok(new AppApiResponse { Succeded = false, Message = "Aynı isimli briden fazla kayıt olduğundan işlem yapılamıyor!" });
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var item = await context.TransportStaticPages.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            context.TransportStaticPages.Remove(item);
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
