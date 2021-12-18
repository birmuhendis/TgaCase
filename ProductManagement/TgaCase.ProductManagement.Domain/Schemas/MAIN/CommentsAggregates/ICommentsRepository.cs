using System.Collections.Generic;
using System.Threading.Tasks;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates
{
    public interface ICommentsRepository : IRepository<Comments,int>
    {
        Task<IList<Comments>> GetByProductId(int productId);
    }
}