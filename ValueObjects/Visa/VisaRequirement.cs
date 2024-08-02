namespace Domain.ValueObjects;
public record VisaRequirement
{
    public string Description { get; init; } = string.Empty;
    public int Numbers { get; init; } = 1;
    public Requirement Requirement { get; init; }
    public Guid VisaId { get; init; }

    private VisaRequirement(Guid visaId, Requirement requirement, int numbers, string description)
    {
        VisaId = visaId;
        Requirement = requirement;
        Numbers = numbers;
        Description = description;
    }

    public static VisaRequirement Create(Guid visaId, Requirement requirement, int numbers, string description)
    {
        return new VisaRequirement(visaId, requirement, numbers, description);
    }
}
    
