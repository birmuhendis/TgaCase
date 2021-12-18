using TgaCase.SharedKernel.SeedWork.Entity;
using TgaCase.SharedKernel.SeedWork.Signatures;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.RoleAggregates
{
    public class Role : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}