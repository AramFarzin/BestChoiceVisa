using Domain.Exceptions;
using Shared.Abstraction.Primitives;

public record DocumentTypeId:IEntityId
{
    public Guid Value{get;}
    public DocumentTypeId(Guid value)
    {
        if(value == Guid.Empty)
        {
           throw new DocumentTypeIdException();
        }
        Value = value;
    }

    public static implicit operator Guid(DocumentTypeId id) => id.Value;
    public static implicit operator DocumentTypeId(Guid id) => new(id);
}
