using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Commands.ProductDetail.Insert
{
    public class Command : IRequest<bool>
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
        public List<string> Images { get; set; }
    }
}