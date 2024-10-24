using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Requirement
{
    public string Description { get; init;} = string.Empty;
    public DocumentType DocumentType { get; init;}

    public Requirement(DocumentType documentType, string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new RequirementDescriptionException();
        }
        if (DocumentType == null)
        {
            throw new RequiredDocumentTypeException();
        }
                
        Description = description;
        DocumentType = documentType;
    }
}