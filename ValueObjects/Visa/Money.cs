namespace Domain.ValueObjects;
public record Money(RequiredString Currency, NoneNegativeDecimalNumber Amount);