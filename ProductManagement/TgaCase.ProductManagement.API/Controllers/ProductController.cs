using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TgaCase.ProductManagement.API.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMediator _mediatr;
        public ProductController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromRoute] Application.Queries.ProductDetail.GetAll.Query query)
            => Ok(await _mediatr.Send(query));
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Application.Queries.ProductDetail.GetLastVersionById.Query query)
            => Ok(await _mediatr.Send(query));
        
        [HttpGet("category/{CategoryId}")]
        public async Task<IActionResult> GetByCategoryId([FromRoute] Application.Queries.ProductDetail.GetByCategoryId.Query query)
            => Ok(await _mediatr.Send(query));
        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] Application.Commands.ProductDetail.Insert.Command command)
            => Ok(await _mediatr.Send(command));
        
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] Application.Commands.ProductDetail.Update.Command command)
            => Ok(await _mediatr.Send(command));

    }
}