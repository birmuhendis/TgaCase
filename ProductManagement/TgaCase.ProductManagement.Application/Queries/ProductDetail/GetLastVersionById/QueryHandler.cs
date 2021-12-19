using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TgaCase.ProductManagement.Domain;
using TgaCase.SharedKernel.SeedWork.Repository;
using TgaCase.SharedKernel.Utilities;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class QueryHandler : IRequestHandler<Query,ProductLastVersionGetByIdDto>
    {
        private IUnitOfWorkFactory<IProductManagementDbContext> _unitOfWork;
        private IMapper _mapper;
        public QueryHandler(IUnitOfWorkFactory<IProductManagementDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ProductLastVersionGetByIdDto> Handle(Query request, CancellationToken cancellationToken)
        {
            using (var uow = _unitOfWork.Create(true, false))
            {
                var lastVersion = await uow.Context.MAIN.ProductDetail.GetLastVersionByIdAsync(request.Id);
                var response = _mapper.Map<ProductLastVersionGetByIdDto>(lastVersion);
                if (response != null)
                {
                    var imagesResponse = await uow.Context.MAIN.ProductImages.GetByProductId(request.Id);
                    var commentsResponse = await uow.Context.MAIN.Comments.GetByProductId(request.Id);
                    var images = _mapper.Map<List<ProductImages>>(imagesResponse);
                    var comment = _mapper.Map<List<Comments>>(commentsResponse);
                    response.Comments = comment.Count > 0 ? comment : new List<Comments>();
                    response.ProductImages = images.Count > 0 ? images : new List<ProductImages>();
                }

                var x = SentimentAnalysis.Analiysis();
                return response;
            }
        }
    }
}