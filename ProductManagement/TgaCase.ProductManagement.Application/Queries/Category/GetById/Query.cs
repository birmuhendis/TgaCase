using System.Collections.Generic;
using MediatR;

namespace TgaCase.ProductManagement.Application.Queries.Category.GetById
{
    public class Query : IRequest<CategoryGetByIdDto>
    {
        public int Id { get; set; }
    }
}