using AutoMapper;

namespace TgaCase.ProductManagement.Application.Commands.ProductImages.Insert
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Command, Domain.Schemas.MAIN.CategoryAggregates.Category>();
        }
    }
}