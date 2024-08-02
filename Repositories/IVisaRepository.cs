using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories;
public interface IVisaRepository: IRepository<Visa> 
{
    Task<IEnumerable<Condition>> GetConditionListAsync(Guid visaId);
    Task<IEnumerable<Criteria>> GetCriteriaListAsync(Guid visaId);
    Task<IEnumerable<VisaRequirement>> GetRequirementListAsync(Guid visaId);
    Task<IEnumerable<Question>> GetQuestionListAsync(Guid visaId);

    // Task<IEnumerable<Visa>> GetVisaListAsync(VisaType? visaType, Country? country);

}