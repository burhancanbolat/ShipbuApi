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
                    p.NameTr,
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
                    p.IsAmazonDepot
                })
                .ToListAsync();
            return Ok(result);
        }

    }
}
