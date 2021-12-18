using System.Data.Common;
using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.Product.GetAll
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductAggregates.Product, ProductGetAllDto>();
        }
    }
}