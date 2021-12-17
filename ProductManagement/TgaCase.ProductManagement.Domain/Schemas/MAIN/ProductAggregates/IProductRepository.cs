using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates
{
    public interface IProductRepository : IRepository<Product, int>
    {
        
    }
}