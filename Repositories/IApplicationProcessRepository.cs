using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories;
public interface IApplicationProcessRepository: IRepository<ApplicationProcess> 
{
    Task<ApplicationProcess> GetByVisaIdAndProcessingCenterIdAsync(VisaId VisaId, ProcessingCenterId processingCenterId);
    Task<IEnumerable<ApplicationProcess>> GetAllApplicationProcessByCountryAsync(Country country);
}