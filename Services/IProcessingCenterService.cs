using Domain.Entities;
using Microsoft.VisualBasic;

namespace Domain.Services;
public interface IProcessingCenterService
{
    Task CreateEmbassyAsync(Embassy embassy);
    Task CreateConsulateAsync(Consulate consulate);
    Task CreateVisaApplicationCenterAsync(VisaApplicationCenter visaApplicationCenter);
    Task EditProcessingCenterAsync(string name,
                                Address address,
                                ContactInfo contactInfo);
    Task DeleteProcessingCenterAsync(Guid id);
    Task AddCounteryToVisaApplicationCenterAsync(Guid CenterId, Country country);
    Task RemoveCounteryFromVisaApplicationCenterAsync(Guid CenterId, Country country);
    Task<ProcessingCenter> GetProcessingCenterByVisaIdAsync(Guid visaId);
}

