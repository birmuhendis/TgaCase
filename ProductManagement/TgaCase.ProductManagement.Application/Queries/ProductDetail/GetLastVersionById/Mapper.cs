using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductDetailAggregates.ProductLastVersionDetail, ProductLastVersionGetByIdDto>();
            CreateMap<Domain.Schemas.MAIN.CommentsAggregates.Comments, Comments>();
            CreateMap<Domain.Schemas.MAIN.ProductImagesAggregates.ProductImages, ProductImages>();
        }
    }
}