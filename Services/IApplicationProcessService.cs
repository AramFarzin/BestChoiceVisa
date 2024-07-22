using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Services;
public interface IApplicationProcessService
{
    Task CreateApplicationProcessAsync(Guid embassyId, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions);
    Task EditApplicationProcessAsync(Guid id, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions);
    Task DeleteApplicationProcessAsync(Guid id);
    Task<IEnumerable<ApplicationProcess>> GetAllApplicationProcessByCountryAsync(Country country);
    Task<ApplicationProcess> GetApplicationProcessesByVisaIdAsync(Guid visaId, Guid processingCenterId);
}


