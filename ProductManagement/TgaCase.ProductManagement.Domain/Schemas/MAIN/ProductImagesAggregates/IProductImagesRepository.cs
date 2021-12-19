using System.Collections.Generic;
using System.Threading.Tasks;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductImagesAggregates
{
    public interface IProductImagesRepository : IRepository<ProductImagesAggregates.ProductImages,int>
    {
        Task<IList<ProductImagesAggregates.ProductImages>> GetByProductId(int productId);

    }
}