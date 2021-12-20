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
                int userId = 0;
                var userCheck = await uow.Context.MAIN.User.GetByMail(request.Mail);
                if (userCheck == null) //maile kayıtlı biri yoksa yeni user oluştur
                {
                    var random = new Random();
                    
                    var userName = $"user{random.Next(1000)}"; //yorumlar için kullanıcılara random isim oluştur
                    var newUser = await uow.Context.MAIN.User.InsertAsync(new Domain.Schemas.MAIN.UserAggregates.User
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        Password = "test", // TO DO!! salt ve hash için cryto util yaz!!
                        Username = userName, 
                        Salt = "XdsaRsa",
                        RoleId = 2,
                        Mail = request.Mail
                    });
                    userId = newUser;
                }
                else
                {
                    userId = userCheck.Id;
                }

                var insert = await uow.Context.MAIN.Comments.InsertAsync(new Domain.Schemas.MAIN.CommentsAggregates.Comments
                {
                    Title = request.Title,
                    Comment = request.Comment,
                    ProductId = request.ProductId,
                    UserId  = userId,
                    Date = DateTime.Now
                });
                uow.CommitTransaction();
                return true;
            }
        }
    }
}