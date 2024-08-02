using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories;
public interface IVisaRepository: IRepository<Visa> 
{
    Task<IEnumerable<Condition>> GetConditionListAsync(VisaId visaId);
    Task<IEnumerable<Criteria>> GetCriteriaListAsync(VisaId visaId);
    Task<IEnumerable<VisaRequirement>> GetRequirementListAsync(VisaId visaId);
    Task<IEnumerable<Question>> GetQuestionListAsync(VisaId visaId);

    // Task<IEnumerable<Visa>> GetVisaListAsync(VisaType? visaType, Country? country);

}