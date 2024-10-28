using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Question
{
    public string Description { get; init;} = string.Empty;

    internal Question(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new QuestionDescriptionException();
        }
        
        Description = description;
    }
    
    public static implicit operator string(Question str) => str.Description;
    public static implicit operator Question(string str) => new(str);

    public override string ToString() => Description;
}
