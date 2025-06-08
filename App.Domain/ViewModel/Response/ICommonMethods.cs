namespace App.Domain.ViewModel.Response;

public interface ICommonMethods<TResponse, TEntity>
{
    TResponse Map(TEntity entity);
}
