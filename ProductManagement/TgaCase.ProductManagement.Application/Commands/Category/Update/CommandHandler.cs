using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Commands.Category.Update
{
    public class CommandHandler : IRequestHandler<Command,bool>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        public IMapper _mapper;
        public CommandHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, true))
            {
                var update = await uow.Context.MAIN.Category.UpdateAsync(new Domain.Schemas.MAIN.CategoryAggregates.Category
                {
                    Id = request.Id,
                    Name =request.Name,
                    ParentId = request.ParentId,
                    IsActive = request.IsActive
                });
                uow.CommitTransaction();
                return true;
            }
        }
    }
}