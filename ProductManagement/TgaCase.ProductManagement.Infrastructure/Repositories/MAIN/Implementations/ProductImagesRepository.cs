using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductImages;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class ProductImagesRepository:  RepositoryBase<ProductImages,int>, IProductImagesRepository
    {
        public ProductImagesRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }
        
        public async Task<IList<ProductImages>> GetByProductId(int productId)
        {            var parameters = new DynamicParameters();
            parameters.Add("@productid", productId, DbType.Int32);
            var sql = $@"select * from ""MAIN"".""ProductImages"" where ""ProductId"" = @productid";
            var response = await DbConnection.QueryAsync<ProductImages>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response.ToList();
        }
        
    }
}