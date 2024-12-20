using Domain.Entities.Visa;
using Domain.ValueObjects;

namespace Domain.Services;
public interface IVisaService
{
    Task CreateVisaAsync(VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                int minimumScore);

    Task SuspendAsync(VisaId id, string reasonOfSuspending);
    Task ReopendAsync(VisaId id);
    Task<IEnumerable<Question>> GetQuestionListAsync(IEnumerable<Visa> visaList);
    Task<IEnumerable<Visa>> GetVisaListAsync(Country? country, VisaType? visaType);
    Task<IEnumerable<Visa>> GetVisaListAsync(IEnumerable<AnswerScore> answerScore);
}

