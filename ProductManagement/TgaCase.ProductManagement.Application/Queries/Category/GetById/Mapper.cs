using System.Data.Common;
using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetById
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.CategoryAggregates.Category, CategoryGetByIdDto>();
        }
    }
}