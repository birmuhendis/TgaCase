using System.Data.Common;
using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetAll
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.CategoryAggregates.Category, CategoryGetAllDto>();
        }
    }
}