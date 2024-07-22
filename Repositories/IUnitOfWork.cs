namespace Domain.Repositories;
public interface IUnitOfWork
{
    Task<int> SavechangesAsync(CancellationToken cancellationToken = default);
}
