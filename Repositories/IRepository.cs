using Domain.Primitives;

namespace Domain.Repositories;
public interface IRepository<T> where T : Entity
{
    Task<T> GetByIdAsync(EntityId id);
    Task<List<T>> GetAsync();
    Task  AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
