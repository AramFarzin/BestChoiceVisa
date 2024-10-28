using Domain.Exceptions;
using Domain.Entities.Visa;

namespace Domain.ValueObjects;
public record Requirement
{
    public string Description { get; init; } = string.Empty;
    public int Numbers { get; init; } = 0;
    public Document Document { get; init; } 
    public DocumentType DocumentType { get; init; }

    internal Requirement(string description, Document document,DocumentType documentType, int numbers)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new RequirementDescriptionException();
        }
        if (Numbers < 0)
        {
            throw new RequiredDocumentNumbersException();
        }
        if (document == null)
        {
            throw new RequirementDocumentException();
        }
        if (documentType == null)
        {
            throw new RequirementDocumentTypeException();
        }

        Description = description;
        Document = document;
        DocumentType = documentType;
        Numbers = numbers;
    }    
}
    
