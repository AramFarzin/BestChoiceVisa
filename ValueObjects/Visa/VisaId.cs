using Domain.Exceptions;
using Shared.Abstraction.Primitives;

public record VisaId:IEntityId
{
    public Guid Value{get;}
    public VisaId(Guid value)
    {
        if(value == Guid.Empty)
        {
           throw new VisaIdException();
        }
        Value = value;
    }

    public static implicit operator Guid(VisaId id) => id.Value;
    public static implicit operator VisaId(Guid id) => new(id);
}
