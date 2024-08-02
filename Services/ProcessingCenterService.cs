using Domain.Entities;

namespace Domain.Services;
public class ProcessingCenterService : IProcessingCenterService
{

    public Task AddCounteryToVisaApplicationCenterAsync(Guid CenterId, Country country)
    {
        throw new NotImplementedException();
    }

    public Task CreateConsulateAsync(Consulate consulate)
    {
        throw new NotImplementedException();
    }

    public Task CreateEmbassyAsync(Embassy embassy)
    {
        throw new NotImplementedException();
    }

    public Task CreateVisaApplicationCenterAsync(VisaApplicationCenter visaApplicationCenter)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProcessingCenterAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task EditProcessingCenterAsync(string name, Address address, ContactInfo contactInfo)
    {
        throw new NotImplementedException();
    }

    public Task<ProcessingCenter> GetProcessingCenterByVisaIdAsync(Guid visaId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveCounteryFromVisaApplicationCenterAsync(Guid CenterId, Country country)
    {
        throw new NotImplementedException();
    }
}