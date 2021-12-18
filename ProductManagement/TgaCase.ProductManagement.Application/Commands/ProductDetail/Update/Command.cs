using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.ProductDetail.Update
{
    public class Command : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
    }
}