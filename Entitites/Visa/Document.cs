using Domain.Exceptions;

namespace Domain.Entities.Visa;
public class Document
{
    public DocumentId Id { get; protected set; }
    private string Name { get; init;} = string.Empty;
    private string Description { get; init;} = string.Empty;

    private Document(DocumentId Id, string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new RequirementNameException();
        }
                
        Name = name.Trim();
        Description = description.Trim();
    }

    internal Document Create(DocumentId Id, string name, string description)
    {
        return new Document(Id, name, description);
    }
}