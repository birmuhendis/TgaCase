using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetAll
{
    public class Query : IRequest<IList<ProductGetAllDto>>
    {
    }
}