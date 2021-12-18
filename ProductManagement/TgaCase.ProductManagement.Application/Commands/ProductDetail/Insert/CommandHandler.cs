using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Application.Commands.ProductDetail.Insert
{
    public class CommandHandler : IRequestHandler<Command,bool>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        public CommandHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, true))
            {
                var productInsertedId = await uow.Context.MAIN.Product.InsertAsync(
                    new Domain.Schemas.MAIN.ProductAggregates.Product
                    {
                        Name = request.Name,
                        UserId = request.UserId,
                        CategoryId = request.CategoryId
                    });
                var productDetailInsert =
                    await uow.Context.MAIN.ProductDetail.InsertAsync(
                        new Domain.Schemas.MAIN.ProductDetailAggregates.ProductDetail
                        {
                            ProductId = productInsertedId,
                            SalesPrice = request.SalesPrice,
                            PurchasePrice = request.PurchasePrice,
                            Quantity = request.Quantity,
                            UpdatedDate = DateTime.Now,
                            Version = 1
                        });
                foreach (var image in request.Images)
                {
                    var img = await uow.Context.MAIN.ProductImages.InsertAsync(
                        new Domain.Schemas.MAIN.ProductImages.ProductImages
                        {
                            Path = image,
                            ProductId = productInsertedId,
                        });
                }
                uow.CommitTransaction();
                return true;
            }
        }
    }
}