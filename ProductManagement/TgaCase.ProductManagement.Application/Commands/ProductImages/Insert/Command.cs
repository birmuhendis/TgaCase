using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.ProductImages.Insert
{
    public class Command : IRequest<bool>
    {
        public string Path { get; set; }
        public int ProductId { get; set; }
    }
}