using App.Domain.Entities;
using App.Domain.Repository;
using App.Domain.ViewModel.Request;
using App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository;

public class UserInformationsRepository(AppDbContext _dbContext) : IUserInformationsRepository
{
    public async Task<UserInformations> CreateAsync(UserInformations user, CancellationToken cancellationToken = default)
    {
        await _dbContext.UserInformations.AddAsync(user, cancellationToken);

        return user;
    }

    public UserInformations? UpdateAsync(UserInformations user, CancellationToken cancellationToken = default)
    {
        user.UpdateValues();
        _dbContext.UserInformations.Update(user);
        return user;
    }

    public async Task<UserInformations?> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.UserInformations.FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);

        user?.DisableEntity();

        return user ?? default;
    }

    public async Task<UserInformations?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.UserInformations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);

        return user ?? default;
    }

    public async Task<List<UserInformations>> GetAllUsers(CancellationToken cancellationToken = default)
    {
        var usersList = await _dbContext.UserInformations
            .AsNoTracking()
            .Where(x => x.IsActive)
            .ToListAsync(cancellationToken);

        return usersList ?? [];
    }
}