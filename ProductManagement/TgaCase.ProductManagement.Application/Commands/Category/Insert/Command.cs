using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.Category.Insert
{
    public class Command : IRequest<bool>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}