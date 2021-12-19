using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TgaCase.ProductManagement.API.Controllers
{
    [Route("product-images")]
    [ApiController]
    public class ProductImagesController : Controller
    {
        private readonly IMediator _mediatr;

        public ProductImagesController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] Application.Commands.ProductImages.Insert.Command command)
            => Ok(await _mediatr.Send(command));

    }
}