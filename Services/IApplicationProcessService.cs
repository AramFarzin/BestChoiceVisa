using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Services;
public interface IApplicationProcessService
{
    Task CreateApplicationProcessAsync(ProcessingCenterId embassyId, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions);
    Task EditApplicationProcessAsync(ApplicationProcessId id, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions);
    Task DeleteApplicationProcessAsync(ApplicationProcessId id);
    Task<IEnumerable<ApplicationProcess>> GetAllApplicationProcessByCountryAsync(Country country);
    Task<ApplicationProcess> GetApplicationProcessesByVisaIdAsync(VisaId visaId, ProcessingCenterId processingCenterId);
}


