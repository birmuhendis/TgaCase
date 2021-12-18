using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.Category.Delete
{
    public class Command : IRequest<bool>
    {
        public int Id { get; set; }
    }
}