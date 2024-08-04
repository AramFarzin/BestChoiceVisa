using Domain.Entities;
using Domain.ValueObjects;
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
    Task DeleteProcessingCenterAsync(ProcessingCenterId id);
    Task AddCounteryToVisaApplicationCenterAsync(ProcessingCenterId CenterId, Country country);
    Task RemoveCounteryFromVisaApplicationCenterAsync(ProcessingCenterId CenterId, Country country);
    Task<ProcessingCenter> GetProcessingCenterByVisaIdAsync(VisaId visaId);
}

