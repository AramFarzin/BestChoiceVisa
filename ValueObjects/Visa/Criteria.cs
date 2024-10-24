using Domain.Exceptions;

namespace Domain.ValueObjects;
public record Criteria
{
    public string Description { get; init;}

    private Criteria(string description) => Description = description;

    public static Criteria Create(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new CriteriaDescriptionException();
        }

        return new Criteria(description);
    }
}
