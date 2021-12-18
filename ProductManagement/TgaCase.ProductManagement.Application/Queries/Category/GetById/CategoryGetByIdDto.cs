namespace TgaCase.ProductManagement.Application.Queries.Category.GetById
{
    public class CategoryGetByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}