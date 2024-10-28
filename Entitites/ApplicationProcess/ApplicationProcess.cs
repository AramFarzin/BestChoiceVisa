using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class ApplicationProcess : AggregateRoot<ApplicationProcessId>
{        
    [Required]
    private ProcessingCenterId _embassyId;
   
    [Required]
    private ProcessType _processType;
   
    [Required]
    private ApplicationProccessDays _processingDays;
    
    [Required]
    private ApplicationProccessInstruction _instructions;

    private ApplicationProcess(ApplicationProcessId id,
                              ProcessingCenterId embassyId,
                              ProcessType processType,
                              ApplicationProccessDays processingDays,
                              ApplicationProccessInstruction instructions) 
    {
        Id = id;
        _embassyId = embassyId;
        _processType = processType;
        _processingDays = processingDays;
        _instructions = instructions;
    }

    public static ApplicationProcess Create(ApplicationProcessId id,
                                            ProcessingCenterId embassyId,
                                            ProcessType processType,
                                            ApplicationProccessDays processingDays,
                                            ApplicationProccessInstruction instructions)
    {
        return  new ApplicationProcess(id,
                                        embassyId,
                                        processType,
                                        processingDays,
                                        instructions);
    }

    public void Edit(ProcessType processType, ApplicationProccessDays minProcessingDays, ApplicationProccessInstruction instructions)
    {
        _processType = processType;
        _processingDays = minProcessingDays;
        _instructions = instructions;
    }   
}




