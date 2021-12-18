using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetByCategoryId
{
    public class Query : IRequest<IList<ProductGetByCategoryIdDto>>
    {
        public int CategoryId { get; set; }
    }
}