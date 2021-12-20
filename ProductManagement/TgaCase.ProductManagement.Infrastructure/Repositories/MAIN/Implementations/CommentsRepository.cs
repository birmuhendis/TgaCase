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

        public async Task<IList<CommentDetail>> GetByProductId(int productId)
        {            var parameters = new DynamicParameters();
            parameters.Add("@productid", productId, DbType.Int32);
            var sql = $@"select u.""FirstName"",u.""LastName"", c.""Title"", c.""Comment"", c.""Date"" from ""MAIN"".""Comments"" c
            inner join ""MAIN"".""User"" u on u.""Id""=c.""UserId"" 
            where ""ProductId"" = @productid";
            var response = await DbConnection.QueryAsync<CommentDetail>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response.ToList();
        }
    }
}