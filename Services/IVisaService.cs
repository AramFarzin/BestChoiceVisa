using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Services;
public interface IVisaService
{
    Task<int> CalculateScoreAsync(Guid id, IEnumerable<AnswerScore> scores);
    Task<IEnumerable<Condition>> GetVisasByAnswersAsync(IEnumerable<AnswerScore> answerScore, int score);
    Task<IEnumerable<Visa>> GetAllVisaByCountryAsync(Country country);
    Task CreateVisaAsync(VisaType visaType,
                Guid applicationProcessId,
                Decimal fees,
                int minimumScore,
                IEnumerable<Condition> conditionList, 
                IEnumerable<Criteria> criteriaList);

    Task SuspendAsync(Guid id);
    Task ReopendAsync(Guid id);
}

