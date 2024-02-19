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
    public class UsersController : ControllerBase
    {

        private readonly AppDbContext context;

        public UsersController(
            AppDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions options)
        {

            var query = context
                .Users
                .AsNoTracking()
                .Select(p=> new
                {
                    p.Id,
                    p.Name,
                    p.UserName,
                    p.DateCreated,
                    p.Email,
                    p.Enabled
                })
                .OrderBy(p => p.Name);


            options.PrimaryKey = new[] { "Id" };
            options.PaginateViaPrimaryKey = true;
            options.DefaultSort = "Name";

            return Ok(await DataSourceLoader.LoadAsync(query, options));
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await context.Users.FindAsync(id));



    }
}
