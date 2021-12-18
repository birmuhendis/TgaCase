using System.Data;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class ProductDetailRepository:  RepositoryBase<ProductDetail,int>, IProductDetailRepository
    {
        public ProductDetailRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }
    }
}