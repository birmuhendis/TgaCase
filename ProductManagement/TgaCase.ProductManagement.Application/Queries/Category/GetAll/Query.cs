using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetAll
{
    public class Query : IRequest<IList<CategoryGetAllDto>>
    {
        
    }
}