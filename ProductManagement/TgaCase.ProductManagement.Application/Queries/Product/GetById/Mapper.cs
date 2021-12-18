using System.Data.Common;
using AutoMapper;

namespace TgaCase.ProductManagement.Application.Queries.Product.GetById
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Domain.Schemas.MAIN.ProductAggregates.Product, ProductGetByIdDto>();
        }
    }
}