using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class CommentsRepository :  RepositoryBase<Comments,int>, ICommentsRepository
    {
        public CommentsRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }

        public async Task<IList<Comments>> GetByProductId(int productId)
        {            var parameters = new DynamicParameters();
            parameters.Add("@productid", productId, DbType.Int32);
            var sql = $@"select * from ""MAIN"".""Comments"" where ""ProductId"" = @productid";
            var response = await DbConnection.QueryAsync<Comments>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response.ToList();
        }
    }
}