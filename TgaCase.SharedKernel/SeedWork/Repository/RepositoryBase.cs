using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace TgaCase.SharedKernel.SeedWork.Repository
{
    public abstract class RepositoryBase
    {
        protected readonly IDbConnection  DbConnection;

        protected readonly IDbTransaction DbTransaction;
        
        protected readonly int            CommandTimeout;
        protected readonly string         SchemaName;
        
        protected RepositoryBase(IDbConnection dbConnection, IDbTransaction dbTransaction,string schemaName, int commandTimeout = 30)
        {
            DbConnection   = dbConnection;
            DbTransaction  = dbTransaction;
            CommandTimeout = commandTimeout;
            SchemaName     = schemaName;
        }
        
    }

    public abstract class RepositoryBase<TEntity, TId> : RepositoryBase, IRepository<TEntity, TId>
        where TEntity : class where TId : struct
    {
        protected RepositoryBase(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }

        public Task<TId> InsertAsync(TEntity input)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity input)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(long Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<TEntity>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(TId id)
        {
            throw new System.NotImplementedException();
        }
    }
}