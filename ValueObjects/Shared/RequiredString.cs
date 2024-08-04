
namespace Domain.ValueObjects;
public record RequiredString
{
    public string Value { get; init;}

    public RequiredString(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("The property cannot be empty.", nameof(value));
        }

        Value = value;
    }

    public override string ToString() => Value;
}
