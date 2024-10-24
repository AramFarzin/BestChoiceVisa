using Domain.Exceptions;

namespace Domain.ValueObjects;
public record DocumentType
{
    public string Name { get; init;}

    public DocumentType(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DocumentTypeNameException();
        }

        Name = new string(name);
    }
}
