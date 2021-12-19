using System;
using System.Collections.Generic;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetAll
{
    public class ProductGetAllDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int  UserId { get; set; }
        public string Username { get; set; }
        public string SalesPrice { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }
    }
}