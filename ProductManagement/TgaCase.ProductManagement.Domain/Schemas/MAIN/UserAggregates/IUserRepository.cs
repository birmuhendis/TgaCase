using System.Threading.Tasks;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Domain.Schemas.MAIN.UserAggregates
{
    public interface IUserRepository : IRepository<User,int>
    {
        Task<User> GetByMail(string mail);
    }
}