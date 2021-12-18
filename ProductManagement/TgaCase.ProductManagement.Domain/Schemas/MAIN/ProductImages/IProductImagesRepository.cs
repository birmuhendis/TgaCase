using System.Collections.Generic;
using System.Threading.Tasks;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductImages
{
    public interface IProductImagesRepository : IRepository<ProductImages,int>
    {
        Task<IList<ProductImages>> GetByProductId(int productId);

    }
}