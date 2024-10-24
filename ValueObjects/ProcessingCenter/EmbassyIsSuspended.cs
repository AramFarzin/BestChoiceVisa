using Domain.Exceptions;

public record EmbassyIsSuspended
{ 
    public bool IsSuspended { get; init;} = false;
    public string Reason { get; init;} = string.Empty;

    public EmbassyIsSuspended(bool isSuspanded, string reason)
    {
        if(isSuspanded && string.IsNullOrWhiteSpace(reason))
        {
            throw new EmbassyReasonOfSuspendingException();
        }
                
        IsSuspended = isSuspanded;
        Reason = reason;
    }

    // Implicit conversion from string to EmbassyIsSuspended
   public static implicit operator EmbassyIsSuspended(string reason) 
    => string.IsNullOrWhiteSpace(reason) ? new(false, string.Empty) : new(true, reason);

    // Explicit conversion for more clarity
    public static explicit operator bool(EmbassyIsSuspended suspended) 
        => suspended.IsSuspended;
        
    public override string ToString() => IsSuspended ? $"Suspended: {Reason}" : "Active";
}
