using App.Domain.Entities;
using App.Domain.ViewModel.Request;

namespace App.Domain.Repository;

public interface IUserInformationsRepository : IRepository<UserInformations>
{
    Task<UserInformations> CreateAsync(UserInformations user, CancellationToken cancellationToken = default);
    UserInformations? UpdateAsync(UserInformations user, CancellationToken cancellationToken = default);
    Task<UserInformations?> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<UserInformations?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<UserInformations>> GetAllUsers(CancellationToken cancellationToken = default);
}
