using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Commands.Category.Delete
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
                var delete = await uow.Context.MAIN.Category.DeleteAsync(request.Id);
                uow.CommitTransaction();
                return true;
            }
        }
    }
}