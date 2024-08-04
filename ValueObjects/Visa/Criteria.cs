namespace Domain.ValueObjects;
public record Criteria
{
    public RequiredString Description { get; init;}

    private Criteria(RequiredString description) => Description = description;

    public static Criteria Create(RequiredString description)
    {
        return new Criteria(description);
    }
}
