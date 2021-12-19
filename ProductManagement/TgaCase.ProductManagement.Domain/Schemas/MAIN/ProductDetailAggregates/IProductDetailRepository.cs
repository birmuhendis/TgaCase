using System.Collections.Generic;
using System.Threading.Tasks;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates
{
    public interface IProductDetailRepository : IRepository<ProductDetail,int>
    {
        Task<ProductLastVersionDetail> GetLastVersionByIdAsync(int id);
        Task<IList<ProductDetailGetBtCategoryId>> GetByCategoryId(int categoryId);
        Task<ProductDetail> GetByProductId(int productId);
        Task<IList<ProductDetailGetBtCategoryId>> GetAllForHomeAsync();

    }
}