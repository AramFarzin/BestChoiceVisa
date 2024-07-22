namespace Domain.ValueObjects;
public record Condition(string Description, Question Question, List<AnswerScore> Answers, bool isRequired = true);