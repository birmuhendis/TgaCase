using AutoMapper;

namespace TgaCase.ProductManagement.Application.Commands.Category.Update
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Command, Domain.Schemas.MAIN.CategoryAggregates.Category>();
        }
    }
}