namespace Domain.ValueObjects;
public record VisaRequirement
{
    public string Description { get; init; } = string.Empty;
    public NoneNegativeIntegerNumber Numbers { get; init; }
    public Requirement Requirement { get; init; }
    public VisaId VisaId { get; init; }

    private VisaRequirement(VisaId visaId, Requirement requirement, NoneNegativeIntegerNumber numbers, string description)
    {
        VisaId = visaId;
        Requirement = requirement;
        Numbers = numbers;
        Description = description;
    }

    public static VisaRequirement Create(VisaId visaId, Requirement requirement, NoneNegativeIntegerNumber numbers, string description)
    {
        return new VisaRequirement(visaId, requirement, numbers, description);
    }
}
    
