namespace App.Domain.Repository;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellation = default);
}
