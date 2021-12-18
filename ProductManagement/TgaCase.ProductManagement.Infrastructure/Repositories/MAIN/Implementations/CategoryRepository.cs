using System.Data;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.CategoryAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class CategoryRepository : RepositoryBase<Category,int>, ICategoryRepository
    {
        public CategoryRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }
    }
}