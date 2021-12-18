using AutoMapper;

namespace TgaCase.ProductManagement.Application.Commands.Comments.Insert
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Command, Domain.Schemas.MAIN.CategoryAggregates.Category>();
        }
    }
}