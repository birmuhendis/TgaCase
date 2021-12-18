using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetNested
{
    public class QueryHandler : IRequestHandler<Query,IEnumerable<CategoryGetNestedDto>>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        private IMapper _mapper;
        public QueryHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoryGetNestedDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, false))
            {
                var categories = await uow.Context.MAIN.Category.GetAllAsync();
                var nested = CreateNestedCategories(categories);
                return nested;
            }
        }
        
        //kategorileri nested şekilde alıyoruz, (id parentid ilişkisi)
        private IEnumerable<CategoryGetNestedDto> CreateNestedCategories(IEnumerable<Domain.Schemas.MAIN.CategoryAggregates.Category> items, long? id = null)
        {
            foreach (var item in id.HasValue ? items.Where(x => x.ParentId == id) : items.Where(x => !x.ParentId.HasValue))
            {
                yield return new CategoryGetNestedDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    IsActive = item.IsActive,
                    Children = CreateNestedCategories(items, item.Id)
                };
            }
        }
    }
}