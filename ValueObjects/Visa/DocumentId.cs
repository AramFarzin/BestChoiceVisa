using Domain.Exceptions;
using Shared.Abstraction.Primitives;

public record DocumentId:IEntityId
{
    public Guid Value{get;}
    public DocumentId(Guid value)
    {
        if(value == Guid.Empty)
        {
           throw new DocumentIdException();
        }
        Value = value;
    }

    public static implicit operator Guid(DocumentId id) => id.Value;
    public static implicit operator DocumentId(Guid id) => new(id);
}
