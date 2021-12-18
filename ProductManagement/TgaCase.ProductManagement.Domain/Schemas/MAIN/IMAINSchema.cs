using TgaCase.ProductManagement.Domain.Schemas.MAIN.CategoryAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.CommentsAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductImages;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.RoleAggregates;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.UserAggregates;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN
{
    public interface IMAINSchema : ISchema
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IUserRepository User { get; }
        IRoleRepository Role { get; }
        ICommentsRepository Comments { get; }
        IProductDetailRepository ProductDetail { get; } 
        IProductImagesRepository ProductImages { get; }
    }
}