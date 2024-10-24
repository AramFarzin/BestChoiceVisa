using Domain.Exceptions;
using Domain.Entities;

namespace Domain.ValueObjects;
public record ProcessType
{
    public string Name {get;}
    public string Description {get;}
    public ProcessingCenterType ProcessingCenterType {get;}
    public ProcessingCenter ProcessingCenter {get;}
    public ProcessType(string name, string description, ProcessingCenterType processingCenterType, ProcessingCenter processingCenter)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
           throw new ApplicationProccessTypeNameException();

        }
        if(string.IsNullOrWhiteSpace(description))
        {
           throw new ApplicationProccessTypeDescriptionException();
        }
        if(ProcessingCenter == null)
        {
           throw new ApplicationProcessingCenterException();
        }
        Name = name;
        Description=description;
        ProcessingCenterType=processingCenterType;
        ProcessingCenter=processingCenter;
    }
}
