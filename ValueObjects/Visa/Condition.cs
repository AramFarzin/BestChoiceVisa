using System.Collections.Immutable;
using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Condition
{
    private readonly ImmutableArray<AnswerScore> _answers;
    
    public string Description { get; init; }
    public Question Question { get; init; }
    public bool IsRequired { get; init; } = true;
    public ImmutableArray<AnswerScore> Answers => _answers; 
   
    internal Condition(string description, Question question, IEnumerable<AnswerScore> answers, bool isRequired = true)
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
        _answers = answers.ToImmutableArray();
    }
}