using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.Product.GetAll
{
    public class Query : IRequest<IList<ProductGetAllDto>>
    {
        
    }
}