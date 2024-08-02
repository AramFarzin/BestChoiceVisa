namespace Domain.ValueObjects;
public record Condition
{
    public string Description { get; init; }
    public Question Question { get; init; }
    public HashSet<AnswerScore> Answers { get; init; } = new();
    public bool IsRequired { get; init; }
    private Condition(string description, Question question, bool isRequired = true)
    {
        Description = description;
        Question = question;
        IsRequired = isRequired;
    }

    internal static Condition Create(string description, Question question, bool isRequired = true)
    {
       var condition =  new Condition(description, question, isRequired);
       //TODO:
       //set condition answers
       return condition;
    }
}