using System.Collections.Generic;
using TgaCase.SharedKernel.SeedWork.Entity;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates
{
    public class Comments : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}