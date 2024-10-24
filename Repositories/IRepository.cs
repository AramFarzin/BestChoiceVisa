using Shared.Abstraction.Primitives;

namespace Domain.Repositories;
public interface IRepository<T> 
{
    Task<T> GetByIdAsync(IEntityId id);
    Task<List<T>> GetAsync();
    Task  AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
