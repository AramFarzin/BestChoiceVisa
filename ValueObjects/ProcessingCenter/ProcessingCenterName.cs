using Domain.Exceptions;

public record ProcessingCenterName
{
     public string Value { get; init;} = string.Empty;

    public ProcessingCenterName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ProccessingCenterNameException();
        }

        Value = value;
    }

    public static implicit operator string(ProcessingCenterName str) => str.Value;
    public static implicit operator ProcessingCenterName(string str) => new(str);
    public override string ToString() => Value;
}
