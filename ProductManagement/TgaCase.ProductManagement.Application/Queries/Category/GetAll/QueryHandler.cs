using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetAll
{
    public class QueryHandler : IRequestHandler<Query,IList<CategoryGetAllDto>>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        private IMapper _mapper;
        public QueryHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<CategoryGetAllDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, false))
            {
                var categories = await uow.Context.MAIN.Category.GetAllAsync();
                var resp = _mapper.Map<IList<CategoryGetAllDto>>(categories);
                return resp;
            }
        }
    }
}