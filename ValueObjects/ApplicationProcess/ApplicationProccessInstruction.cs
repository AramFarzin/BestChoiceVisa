
using Domain.Exceptions;

namespace Domain.ValueObjects;
public record ApplicationProccessInstruction
{
    public string Value { get; init;} = string.Empty;

    public ApplicationProccessInstruction(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ApplicationProccessInstructionException();
        }

        Value = value;
    }

    public static implicit operator string(ApplicationProccessInstruction str) => str.Value;
    public static implicit operator ApplicationProccessInstruction(string str) => new(str);
    public override string ToString() => Value;
}
