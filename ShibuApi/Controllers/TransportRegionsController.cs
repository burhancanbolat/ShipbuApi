using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipbuData;

namespace ShipbuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransportRegionsController : ControllerBase
    {
        private readonly AppDbContext context;

        public TransportRegionsController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet("origins")]
        public async Task<IActionResult> GetOrigins()
        {
            var result = await context
                .TransportRegions
                .AsNoTracking()
                .Where(p => p.IsOrigin && p.Enabled)
                .Select(p => new
                {
                    p.Id,
                    p.NameEn,
                    p.NameTr,
                })
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet("destinations")]
        public async Task<IActionResult> GetDestinations()
        {
            var result = await context
                .TransportRegions
                .AsNoTracking()
                .Where(p => p.IsDestination && p.Enabled)
                .Select(p => new
                {
                    p.Id,
                    p.NameEn,
                    p.NameTr
                })
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet("methods/{regionId:guid}")]
        public async Task<IActionResult> GetTransportMethods(Guid regionId)
        {
            var result = await context
                .TransportMethods
                .AsNoTracking()
                .Where(p => p.TransportRegions.Any(q => q.Id == regionId))
                .Select(p => new
                {
                    p.Id,
                    p.NameEn,
                    p.NameTr
                })
                .ToListAsync();
            return Ok(result);
        }
        
        [HttpGet("districts/{regionId:guid}")]
        public async Task<IActionResult> GetDistricts(Guid regionId)
        {
            var result = await context
                .TransportDistricts
                .AsNoTracking()
                .Where(p => p.Enabled && p.RegionId == regionId)
                .OrderBy(p => p.IsAmazonDepot)
                .ThenBy(p => p.NameTr)
                .Select(p => new
                {
                    p.Id,
                    p.NameEn,
                    p.NameTr,
                    p.RegionId,
                    p.IsAmazonDepot,

                })
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet("fees/{districtId:guid}/{methodId:guid}")]
        public async Task<IActionResult> GetTransportFees(Guid districtId, Guid methodId)
        {
            var result = await context
                .TransportFees
                .AsNoTracking()
                .Where(p => p.DistrictId == districtId && p.MethodId == methodId)
                .OrderBy(p=>p.MinWeight)
                .Select(p => new
                {
                    p.Id,
                    p.MaxWeight,
                    p.MethodId,
                    p.MinWeight,
                    p.Value,
                    p.DistrictId
                })
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet("updatefee/{id:guid}/{fee:decimal}")]
        public async Task<IActionResult> UpdateFee(Guid id, decimal fee)
        {
            var result = await context
                .TransportFees
                .FindAsync(id);
            result!.Value = fee;
            context.TransportFees.Update(result);
            await context.SaveChangesAsync();
            return Ok(result);
        }

    }
}
