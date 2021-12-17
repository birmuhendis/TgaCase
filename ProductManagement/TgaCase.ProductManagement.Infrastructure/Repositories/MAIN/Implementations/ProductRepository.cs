using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class ProductRepository :  RepositoryBase<Product,int>, IProductRepository
    {
        public ProductRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
            
        }
    }
}