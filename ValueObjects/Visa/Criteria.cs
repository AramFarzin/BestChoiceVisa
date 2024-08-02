namespace Domain.ValueObjects;
public record Criteria
{
    public string Description { get; }

    private Criteria(string description) => Description = description;

    public static Criteria Create(string description)
    {
        return new Criteria(description);
    }
}
