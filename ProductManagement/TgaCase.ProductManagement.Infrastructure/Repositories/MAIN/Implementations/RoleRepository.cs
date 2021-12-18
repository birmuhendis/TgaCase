using System.Data;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.RoleAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class RoleRepository :  RepositoryBase<Role,int>, IRoleRepository
    {
        public RoleRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }
    }
}