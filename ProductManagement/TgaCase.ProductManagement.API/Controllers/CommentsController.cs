using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TgaCase.ProductManagement.API.Controllers
{
    [Route("comments")]
    [ApiController]
    public class CommentsController : Controller
    {
        private readonly IMediator _mediatr;

        public CommentsController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] Application.Commands.Comments.Insert.Command command)
            => Ok(await _mediatr.Send(command));

    }
}