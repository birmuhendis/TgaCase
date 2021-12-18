using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.Comments.Insert
{
    public class Command : IRequest<bool>
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}