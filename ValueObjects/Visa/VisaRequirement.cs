namespace Domain.ValueObjects;
public record VisaRequirement(Guid visaId, Requirement requirement, int numbers, string description);
