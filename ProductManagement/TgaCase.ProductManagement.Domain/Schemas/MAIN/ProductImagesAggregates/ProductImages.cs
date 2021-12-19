using TgaCase.SharedKernel.SeedWork.Entity;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductImagesAggregates
{
    public class ProductImages : BaseEntity, IEntity
    {
        public string Path { get; set; }
        public int ProductId { get; set; }
    }
}