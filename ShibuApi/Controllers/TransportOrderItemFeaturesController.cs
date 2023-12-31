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
    public class TransportOrderItemFeaturesController : ControllerBase
    {
        private readonly AppDbContext context;

        public TransportOrderItemFeaturesController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {
            var query = context.TransportOrderItemFeatures;

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "DisplayOrder";

            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await context.TransportOrderItemFeatures.FindAsync(id);

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportOrderItemFeatureViewModel model)
        {
            var item = new TransportOrderItemFeature
            {
                Enabled = model.Enabled,
                NameTr = model.NameTr,
                NameEn = model.NameEn,
                DescriptionTr = model.DescriptionTr,
                DescriptionEn = model.DescriptionEn,
                AttachmentDescriptionTr = model.AttachmentDescriptionTr,
                AttachmentDescriptionEn = model.AttachmentDescriptionEn,
                Type = model.Type,
                DisplayOrder = (context.TransportOrderItemFeatures.OrderByDescending(p => p.DisplayOrder).FirstOrDefault()?.DisplayOrder ?? 0) + 1,
            };
            context.TransportOrderItemFeatures.Add(item);
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
        public async Task<IActionResult> Put(Guid id, TransportOrderItemFeatureViewModel model)
        {
            var item = await context.TransportOrderItemFeatures.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            item.Enabled = model.Enabled;
            item.NameTr = model.NameTr;
            item.NameEn = model.NameEn;
            item.DescriptionTr = model.DescriptionTr;
            item.DescriptionEn = model.DescriptionEn;
            item.Type = model.Type;
            item.AttachmentDescriptionTr = item.AttachmentDescriptionTr;
            item.AttachmentDescriptionEn = item.AttachmentDescriptionEn;
            item.DisplayOrder = model.DisplayOrder;
            context.TransportOrderItemFeatures.Update(item);
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
            var subject = await context.TransportOrderItemFeatures.FindAsync(fromId);
            var target = await context.TransportOrderItemFeatures.FindAsync(toId);

            if (subject is null || target is null)
                return BadRequest($"Bulunamadı!");

            if (subject.DisplayOrder > target.DisplayOrder)
                context
                    .TransportOrderItemFeatures
                    .OrderBy(p => p.DisplayOrder)
                    .Where(p => p.DisplayOrder >= target.DisplayOrder && p.DisplayOrder < subject.DisplayOrder)
                    .ExecuteUpdate(p => p.SetProperty(q => q.DisplayOrder, r => r.DisplayOrder + 1));
            else
                context
                    .TransportOrderItemFeatures
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
            var item = await context.TransportOrderItemFeatures.FindAsync(id);

            if (item is null)
                return BadRequest($"{id} bulunamadı!");

            context.TransportOrderItemFeatures.Remove(item);
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
