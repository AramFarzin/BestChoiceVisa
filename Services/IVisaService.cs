using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Services;
public interface IVisaService
{
    Task CreateVisaAsync(VisaType visaType,
                Country country,
                Guid applicationProcessId,
                Money fees,
                int minimumScore);

    Task SuspendAsync(Guid id, string reasonOfSuspending);
    Task ReopendAsync(Guid id);
    Task<IEnumerable<Question>> GetQuestionListAsync(IEnumerable<Visa> visaList);
    Task<IEnumerable<Visa>> GetVisaListAsync(Country? country, VisaType? visaType);
    Task<IEnumerable<Visa>> GetVisaListAsync(IEnumerable<AnswerScore> answerScore);
}

