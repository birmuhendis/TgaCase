using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetNested
{
    public class Query : IRequest<IEnumerable<CategoryGetNestedDto>>
    {
        
    }
}