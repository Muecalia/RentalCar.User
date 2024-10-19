using Microsoft.AspNetCore.Identity;

namespace RentalCar.User.Core.Repositories
{
    public interface IRoleRepository
    {
        Task<IdentityRole> Create(string name);
        Task<bool> Update(IdentityRole role);
        Task<bool> Delete(IdentityRole role);
        Task<bool> Exists(string role, CancellationToken cancellationToken);
        Task<IdentityRole> GetById(string Id, CancellationToken cancellationToken);
        Task<List<IdentityRole>> GetAll(CancellationToken cancellationToken);
    }
}
