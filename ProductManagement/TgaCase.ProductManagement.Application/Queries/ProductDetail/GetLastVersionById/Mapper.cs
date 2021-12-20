using AutoMapper;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates;
using TgaCase.SharedKernel.Extensions;
using TgaCase.SharedKernel.Utilities;
using VaderSharp2;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductDetailAggregates.ProductLastVersionDetail, ProductLastVersionGetByIdDto>().ForMember(dest => dest.SalesPrice, opt=>opt.MapFrom(src=> src.SalesPrice.ToTurkishCurrency()));;
            CreateMap<Domain.Schemas.MAIN.CommentsAggregates.CommentDetail, Comments>().ForMember(dest => dest.SentimentAnalysis, opt=> opt.MapFrom(src => SentimentAnalysis.Analiysis(src.Comment)))
                .ForMember(dest=> dest.Date, opt=> opt.MapFrom(src=> src.Date.ToDateString()));
            CreateMap<Domain.Schemas.MAIN.ProductImagesAggregates.ProductImages, ProductImages>();
        }
    }
}