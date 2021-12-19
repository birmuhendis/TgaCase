using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Commands.ProductImages.Insert
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
            //TO DO 
            //resimleri base64 şeklinde alıp, headırını kontrol edip(gerçekten image olup olmadığını almaka için) belirlenen path'e resmi kopyalayıp, ismini databaseye kaydetmek gerekiyor.
            using (var uow = _unitOfWork.Create(true, true))
            {
                var insert = await uow.Context.MAIN.ProductImages.InsertAsync(new Domain.Schemas.MAIN.ProductImagesAggregates.ProductImages
                {
                    ProductId = request.ProductId,
                    Path = request.Path
                });
                uow.CommitTransaction();
                return true;
            }
        }
    }
}