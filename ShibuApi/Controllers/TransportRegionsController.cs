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
        public async Task<IActionResult> GetOrigins(DataSourceLoadOptions options)
        {
            var query = context
                .TransportRegions
                .Where(p => p.IsOrigin && p.Enabled);

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;


            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }

        [HttpGet("destinations")]
        public async Task<IActionResult> GetDestinations(DataSourceLoadOptions options)
        {
            var query = context
                .TransportRegions
                .Include(p => p.Districts)
                .Where(p => p.IsDestination && p.Enabled)
                .Select(p => new
                {
                    p.Id,
                    p.NameEn,
                    p.NameTr,
                    Districts = p.Districts.Where(p => p.Enabled).OrderBy(q => q.IsAmazonDepot).Select(q => new { q.Id, q.IsAmazonDepot, q.NameTr, q.NameEn, })
                });

            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;


            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }
    }
}
