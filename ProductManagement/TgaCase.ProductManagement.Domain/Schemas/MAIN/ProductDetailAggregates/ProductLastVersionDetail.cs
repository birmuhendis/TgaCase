using System;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates
{
    public class ProductLastVersionDetail : IModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int  UserId { get; set; }
        public string Username { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CategoryName { get; set; }
    }
}