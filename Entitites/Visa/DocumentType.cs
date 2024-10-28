using Domain.Exceptions;

namespace Domain.Entities.Visa;
public class DocumentType
{
    public DocumentTypeId Id { get; protected set; }
    internal string Name { get; init;}

    private DocumentType(DocumentTypeId id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DocumentTypeNameException();
        }
        Id = id;
        Name = new string(name);
    }

    internal DocumentType Create(DocumentTypeId id, string name)
    {
        return new DocumentType(id, name);
    }
}
