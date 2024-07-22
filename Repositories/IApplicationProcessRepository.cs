using Domain.Entities;
using Domain.Primitives;

namespace Domain.Repositories;
public interface IApplicationProcessRepository: IRepository<ApplicationProcess> 
{
    Task<ApplicationProcess> GetByVisaIdAndProcessingCenterIdAsync(Guid VisaId, Guid processingCenterId);
    Task<IEnumerable<ApplicationProcess>> GetAllApplicationProcessByCountryAsync(Country country);
}