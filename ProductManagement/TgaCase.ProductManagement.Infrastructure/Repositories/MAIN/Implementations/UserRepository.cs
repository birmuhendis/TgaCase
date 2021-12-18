using System.Data;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.UserAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class UserRepository:  RepositoryBase<User,int>, IUserRepository
    {
        public UserRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }
    }
}