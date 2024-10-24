using Domain.Exceptions;
namespace Domain.ValueObjects;

public record VisaType
{
    public string Name { get; init;}
    public string Description { get; init;}
    public int MinimumDuration { get; init;}
    public int MaximumDuration { get; init;}

    public VisaType(string name, string description, int minimumDuration, int maximumDuration)
    {

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new VisaTypeNameException();
        }

        if (minimumDuration >  MaximumDuration )
        {
            throw new VisaTypePeriodTimeException();
        }

        Name = new string(name);
        Description = description;
        MinimumDuration = minimumDuration;
        MaximumDuration = maximumDuration;
    }
}