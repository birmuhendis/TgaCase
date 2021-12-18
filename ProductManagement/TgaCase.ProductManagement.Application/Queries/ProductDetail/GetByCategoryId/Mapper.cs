using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetByCategoryId
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductDetailAggregates.ProductDetailGetBtCategoryId, ProductGetByCategoryIdDto>();
        }
    }
}