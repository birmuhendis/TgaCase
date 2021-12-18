using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.Product.GetById
{
    public class Query : IRequest<ProductGetByIdDto>
    {
        public int Id { get; set; }
    }
}