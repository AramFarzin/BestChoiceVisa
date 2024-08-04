namespace Domain.ValueObjects;
public record AnswerScore(RequiredString Answer, NoneNegativeIntegerNumber Score);