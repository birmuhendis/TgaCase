using System;
using System.Collections.Generic;
using VaderSharp2;

namespace TgaCase.ProductManagement.Application.Queries.ProductDetail.GetLastVersionById
{
    public class ProductLastVersionGetByIdDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int  UserId { get; set; }
        public string Username { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CategoryName { get; set; }
        
        public List<ProductImages> ProductImages { get; set; }
        public List<Comments> Comments { get; set; }
        public ProductLastVersionGetByIdDto()
        {
            ProductImages = new List<ProductImages>();
            Comments = new List<Comments>();
        }
    }
    public class ProductImages
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }
    
    public class Comments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public SentimentAnalysisResults SentimentAnalysis { get; set; }
    }
}