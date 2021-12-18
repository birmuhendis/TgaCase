using TgaCase.SharedKernel.SeedWork.Entity;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates
{
    public class Product :BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}