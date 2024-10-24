using Domain.Exceptions;

namespace Domain.ValueObjects;
public record ApplicationProccessDays
{
    public int Max {get;}
    public int Min {get;}

    public ApplicationProccessDays(int min, int max)
    {
        if (max<min)
        {
            throw new ApplicationProccessDaysException();
        }

        Max = max;
        Min = min;
    }
}
