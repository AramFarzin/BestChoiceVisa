using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Condition
{
    public string Description { get; init; }
    public Question Question { get; init; }
    public LinkedList<AnswerScore> Answers { get; init; } = new();
    public bool IsRequired { get; init; }
    private Condition(string description, Question question, bool isRequired = true)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ConditionDescriptionException();
        }

        if (question == null)
        {
            throw new ConditionQuestionException();
        }

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