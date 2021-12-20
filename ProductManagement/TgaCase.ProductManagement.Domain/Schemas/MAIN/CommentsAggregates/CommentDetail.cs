using System;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates
{
    public class CommentDetail : IModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

    }
}