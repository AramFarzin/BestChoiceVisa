using Domain.ValueObjects;

namespace Domain.Entities;
public interface IApplicationProcessFactory
{      
    public ApplicationProcess Create(ApplicationProcessId id,
                                            ProcessingCenterId embassyId,
                                            ProcessType processType,
                                            ApplicationProccessDays processingDays,
                                            ApplicationProccessInstruction instructions);
}
