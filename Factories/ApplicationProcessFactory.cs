using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class ApplicationProcessFactory : IApplicationProcessFactory
{      
    public ApplicationProcess Create(ApplicationProcessId id,
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
}
