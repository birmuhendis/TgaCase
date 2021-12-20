using System.Data;
using System.Threading.Tasks;
using Dapper;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.UserAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class UserRepository:  RepositoryBase<User,int>, IUserRepository
    {
        public UserRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }

        public async Task<User> GetByMail(string mail)
        {            
            var parameters = new DynamicParameters();
            parameters.Add("@mail", mail, DbType.String);
            var sql = $@"select * from ""MAIN"".""User"" where ""Mail"" = @mail";
            var response = await DbConnection.QueryFirstOrDefaultAsync<User>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response;
        }
    }
}