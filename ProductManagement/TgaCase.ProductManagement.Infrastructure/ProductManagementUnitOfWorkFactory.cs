using Microsoft.Extensions.Configuration;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure
{
   
    public class ProductManagementUnitOfWorkFactory : IUnitOfWorkFactory<IProductManagementDbContext>
    {
        private readonly IConfiguration _configuration;

        public ProductManagementUnitOfWorkFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public UnitOfWork<IProductManagementDbContext> Create()
        {
            var s = _configuration.GetConnectionString("postgresql");
            return new UnitOfWork<IProductManagementDbContext>(new ProductManagementDbContext(s, _configuration.GetValue<int>("ErpDBCommandTimeout")));
        }

        public UnitOfWork<IProductManagementDbContext> Create(bool openConnection, bool startTransaction)
        {
            var unitOfWork = Create();

            if (openConnection)
            {
                unitOfWork.OpenConnection();
            }

            if (startTransaction)
            {
                unitOfWork.BeginTransaction();
            }

            return unitOfWork;
        }
    }

}