using System.ComponentModel.DataAnnotations;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class ApplicationProcess : Entity
{        
    [Required]
    public Guid EmbassyId { get; private set; }

    [Required]
    public ProcessType ProcessType { get; private set; }

    [Required]
    public int MinProcessingTime  { get; private set; } 
    
    [Required]
    public int MaxProcessingTime  { get; private set; } 
    
    [Required]
    public string Instructions  { get; private set; } 

    public ApplicationProcess(Guid id,
                              Guid embassyId,
                              ProcessType processType,
                              int minProcessingTime,
                              int maxProcessingTime,
                              string instructions) : base(id)
    {
        EmbassyId = embassyId;
        ProcessType = processType;
        MinProcessingTime = minProcessingTime;
        MaxProcessingTime = maxProcessingTime;
        Instructions = instructions ;
    }

    public void Edit(ProcessType processType, int minProcessingTime, int maxProcessingTime, string instructions)
    {
        ProcessType = processType;
        MinProcessingTime = minProcessingTime;
        MaxProcessingTime = maxProcessingTime;
        Instructions = instructions;
    }
}

