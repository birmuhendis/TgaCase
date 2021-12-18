using TgaCase.ProductManagement.Domain.Schemas.MAIN.CategoryAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN
{
    public interface IMAINSchema : ISchema
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
    }
}