namespace Domain.ValueObjects;
public record VisaType(RequiredString Name, string Description, NoneNegativeIntegerNumber MinimumDuration, NoneNegativeIntegerNumber MaximumDuration);