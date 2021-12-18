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
        public async Task<IActionResult> GetAll([FromQuery] Application.Queries.Product.GetAll.Query query)
            => Ok(await _mediatr.Send(query));
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Application.Queries.Product.GetById.Query query)
            => Ok(await _mediatr.Send(query));
    }
}