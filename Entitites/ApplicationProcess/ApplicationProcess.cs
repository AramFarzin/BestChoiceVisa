using System.ComponentModel.DataAnnotations;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class ApplicationProcess : Entity
{        
    [Required]
    public ProcessingCenterId EmbassyId { get; private set; }

    [Required]
    public ProcessType ProcessType { get; private set; }

    [Required]
    public int MinProcessingDays  { get; private set; }  = 0;
    
    [Required]
    public int MaxProcessingDays  { get; private set; }  = 0;
    
    [Required]
    public string Instructions  { get; private set; } = string.Empty;

    private ApplicationProcess(ApplicationProcessId id,
                              ProcessingCenterId embassyId,
                              ProcessType processType,
                              int minProcessingDays,
                              int maxProcessingDays,
                              string instructions) : base(id)
    {
        EmbassyId = embassyId;
        ProcessType = processType;
        MinProcessingDays = minProcessingDays;
        MaxProcessingDays = maxProcessingDays;
        Instructions = instructions ;
    }

    public static ApplicationProcess Create(ApplicationProcessId id,
                                            ProcessingCenterId embassyId,
                                            ProcessType processType,
                                            int minProcessingDays,
                                            int maxProcessingDays,
                                            string instructions)
    {
        return  new ApplicationProcess(id,
                                        embassyId,
                                        processType,
                                        minProcessingDays,
                                        maxProcessingDays,
                                        instructions);
    }

    public void Edit(ProcessType processType, int minProcessingDays, int maxProcessingDays, string instructions)
    {
        ProcessType = processType;
        MinProcessingDays = minProcessingDays;
        MaxProcessingDays = maxProcessingDays;
        Instructions = instructions;
    }   
}




