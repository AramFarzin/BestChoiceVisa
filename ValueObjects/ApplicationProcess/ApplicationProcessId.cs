using Domain.Exceptions;
using Shared.Abstraction.Primitives;

public record ApplicationProcessId :IEntityId
{
    public Guid Value{get;}
    public ApplicationProcessId(Guid value)
    {
        if(value == Guid.Empty)
        {
           throw new ApplicationProccessIdException();
        }
        Value = value;
    }

    public static implicit operator Guid(ApplicationProcessId id) => id.Value;
    public static implicit operator ApplicationProcessId(Guid id) => new(id);
}

