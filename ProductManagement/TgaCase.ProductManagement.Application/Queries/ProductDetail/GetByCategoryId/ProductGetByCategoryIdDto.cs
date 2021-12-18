using System;
using System.Collections.Generic;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetByCategoryId
{
    public class ProductGetByCategoryIdDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int  UserId { get; set; }
        public string Username { get; set; }
        public decimal SalesPrice { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }
    }
}