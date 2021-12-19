using AutoMapper;
using TgaCase.SharedKernel.Utilities;
using VaderSharp2;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductDetailAggregates.ProductLastVersionDetail, ProductLastVersionGetByIdDto>();
            CreateMap<Domain.Schemas.MAIN.CommentsAggregates.Comments, Comments>().ForMember(dest => dest.SentimentAnalysis, opt=> opt.MapFrom(src => SentimentAnalysis.Analiysis(src.Comment)));
            CreateMap<Domain.Schemas.MAIN.ProductImagesAggregates.ProductImages, ProductImages>();
        }
    }
}