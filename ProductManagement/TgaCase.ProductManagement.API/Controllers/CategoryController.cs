using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TgaCase.ProductManagement.API.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IMediator _mediatr;
        public CategoryController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] Application.Queries.Category.GetAll.Query query)
            => Ok(await _mediatr.Send(query));
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Application.Queries.Category.GetById.Query query)
            => Ok(await _mediatr.Send(query));
        
        [HttpGet("get-nested")]
        public async Task<IActionResult> GetNested([FromRoute] Application.Queries.Category.GetNested.Query query)
            => Ok(await _mediatr.Send(query));
    }
}