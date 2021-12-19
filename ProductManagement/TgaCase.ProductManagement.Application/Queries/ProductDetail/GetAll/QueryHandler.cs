using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetAll
{
    public class QueryHandler : IRequestHandler<Query,IList<ProductGetAllDto>>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        private IMapper _mapper;
        public QueryHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<ProductGetAllDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, false))
            {
                var lastVersion = await uow.Context.MAIN.ProductDetail.GetAllForHomeAsync();
                var response = _mapper.Map<IList<ProductGetAllDto>>(lastVersion);
                return response;
            }
        }
    }
}