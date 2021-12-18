using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class Query : IRequest<ProductLastVersionGetByIdDto>
    {
        public int Id { get; set; }
    }
}