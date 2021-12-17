using TgaCase.ProductManagement.Domain.Schemas.MAIN;
using TgaCase.SharedKernel.SeedWork.Context;

namespace TgaCase.ProductManagement.Domain
{
    public interface IProductManagementDbContext : IDbContext
    {
        IMAINSchema MAIN { get; }
    }
}