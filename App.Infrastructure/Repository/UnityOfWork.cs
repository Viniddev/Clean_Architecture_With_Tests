using App.Domain.Repository;
using App.Infrastructure.Data;

namespace App.Infrastructure.Repository;

public class UnitOfWork(AppDbContext _dbContext) : IUnitOfWork
{
    public async Task CommitAsync(CancellationToken cancellationToken)
    {
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
