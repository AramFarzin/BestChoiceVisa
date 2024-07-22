using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Services;
public class VisaService : IVisaService
{
    public async Task<int> CalculateScoreAsync(Guid id, IEnumerable<AnswerScore> scores)
    {
        // check if visa does exist
       // TODO
        return scores.Sum(s => s.Score);
    }

    public Task CreateVisaAsync(VisaType visaType, Guid applicationProcessId, decimal fees, int minimumScore, IEnumerable<Condition> conditionList, IEnumerable<Criteria> criteriaList)
    {
        // check if visaType needs to be created
        // Question needs to be created
        // Answerscore needs to be created
        // Conditions needs to be created
        // criteriaList needs to be created
        // visa need to be created
        throw new NotImplementedException();
    }

    public Task EditAsync(Visa visa)
    {
        // check if visa does exist
        // UpdateAsync visa
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Visa>> GetAllVisaByCountryAsync(Country country)
    {
        // check if Country does exist
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Condition>> GetVisasByAnswersAsync(IEnumerable<AnswerScore> answerScore, int score)
    {
        // check if answerScores do exist
        throw new NotImplementedException();
    }

    public Task ReopendAsync(Guid id)
    {
        // check if visa does exist
        throw new NotImplementedException();
    }

    public Task SuspendAsync(Guid id)
    {
        // check if visa does exist
        throw new NotImplementedException();
    }
}