using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Queries.Product.GetAll
{
    public class QueryHandler : IRequestHandler<Query,IList<ProductGetAllDto>>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;

        public QueryHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<ProductGetAllDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, false))
            {
                var product = await uow.Context.MAIN.Product.GetAllAsync();
;                throw new System.NotImplementedException();   
            }
        }
    }
}