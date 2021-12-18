using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Commands.Comments.Insert
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
                var insert = await uow.Context.MAIN.Comments.InsertAsync(new Domain.Schemas.MAIN.CommentsAggregates.Comments
                {
                    Title = request.Title,
                    Comment = request.Comment,
                    ProductId = request.ProductId,
                    UserId  = request.UserId,
                    Date = DateTime.Now
                });
                uow.CommitTransaction();
                return true;
            }
        }
    }
}