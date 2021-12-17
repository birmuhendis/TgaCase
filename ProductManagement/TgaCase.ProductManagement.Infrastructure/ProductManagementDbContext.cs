using TgaCase.ProductManagement.Domain;
using TgaCase.ProductManagement.Domain.Schemas.MAIN;
using TgaCase.ProductManagement.Infrastructure.Repositories.MAIN;
using TgaCase.SharedKernel.SeedWork.Context;

namespace TgaCase.ProductManagement.Infrastructure
{
    public class ProductManagementDbContext : PostgreSqlDbContext, IProductManagementDbContext
    {
        public ProductManagementDbContext(string connectionString, int commandTimeout) : base(connectionString, commandTimeout)
        {
        }
        
        //buradaki şema ismini elle yazdım, bu işlem bi extensions yazarak yapılabır
        public IMAINSchema MAIN => new MAINSchema(Connection, Transaction, CommandTimeout, "MAIN");
    }
}