namespace TgaCase.ProductManagement.Application.Queries.Category.GetAll
{
    public class CategoryGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}