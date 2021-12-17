using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates
{
    public class Product : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}