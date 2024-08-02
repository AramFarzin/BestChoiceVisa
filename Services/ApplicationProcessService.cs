using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Domain.Services;
public class ApplicationProcessService : IApplicationProcessService
{
    private readonly IApplicationProcessRepository _applicationProcessRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ApplicationProcessService(IApplicationProcessRepository applicationProcessRepository, IUnitOfWork unitOfWork)
    {
        _applicationProcessRepository = applicationProcessRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task  CreateApplicationProcessAsync(Guid embassyId, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions)
    {
        var process = ApplicationProcess.Create(embassyId, processType, minProcessingTime, maxProcessingTime, instructions);
        await _applicationProcessRepository.AddAsync(process);
    }

    public async Task EditApplicationProcessAsync(Guid id, ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions)
    {
        // Asynchronously get the process by ID
        var process = await _applicationProcessRepository.GetByIdAsync(id);
        
        if (process == null)
        {
            throw new Exception("Process not found");
        }

        // Update process properties
        process.Edit(processType, minProcessingTime, maxProcessingTime, instructions);

        // Asynchronously update the process
        await _applicationProcessRepository.UpdateAsync(process);

        // Commit changes asynchronously using the unit of work
        await _unitOfWork.SavechangesAsync();
    }

    public async Task DeleteApplicationProcessAsync(Guid id)
    {
        var process = await _applicationProcessRepository.GetByIdAsync(id);
        if (process == null)
        {
            throw new Exception("Process not found");
        }

        await _applicationProcessRepository.DeleteAsync(process);
    }


    public async Task<ApplicationProcess> GetApplicationProcessesByVisaIdAsync(Guid visaId, Guid processingCenterId)
    {
        return await _applicationProcessRepository.GetByVisaIdAndProcessingCenterIdAsync(visaId, processingCenterId);
    }

    public async Task<IEnumerable<ApplicationProcess>> GetAllApplicationProcessByCountryAsync(Country country)
    {
        return await _applicationProcessRepository.GetAllApplicationProcessByCountryAsync(country);
    }
}