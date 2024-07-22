using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories;
public interface IVisaRepository: IRepository<Visa> 
{
    Task<IEnumerable<Condition>> GetConditionListAsync(Guid id);
    Task<IEnumerable<Criteria>> GetCriteriaListAsync(Guid id);
}