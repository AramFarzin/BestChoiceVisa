using Domain.Exceptions;

namespace Domain.ValueObjects;
public record VisaRequirement
{
    public string Description { get; init; } = string.Empty;
    public int Numbers { get; init; } = 0;
    public Requirement Requirement { get; init; }
    public VisaId VisaId { get; init; }

    private VisaRequirement(VisaId visaId, Requirement requirement, int numbers, string description)
    {
        if (Numbers < 0)
        {
            throw new RequiredDocumentNumbersException();
        }

        VisaId = visaId;
        Requirement = requirement;
        Numbers = numbers;
        Description = description;
    }

    public static VisaRequirement Create(VisaId visaId, Requirement requirement, int numbers, string description)
    {
        return new VisaRequirement(visaId, requirement, numbers, description);
    }
}
    
