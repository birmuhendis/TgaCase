using System;
using TgaCase.SharedKernel.SeedWork.Entity;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates
{
    public class ProductDetail :BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Version { get; set; }
    }
}