using Domain.Exceptions;
using Shared.Abstraction.Primitives;

public record ProcessingCenterId:IEntityId
{
    public Guid Value{get;}
    public ProcessingCenterId(Guid value)
    {
        if(value == Guid.Empty)
        {
           throw new ProccessingCenterIdException();
        }
        Value = value;
    }

    public static implicit operator Guid(ProcessingCenterId id) => id.Value;
    public static implicit operator ProcessingCenterId(Guid id) => new(id);
}

