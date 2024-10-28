using Domain.Exceptions;

public record VisaSuspended
{ 
    public string Reason { get; private set;} = string.Empty;
    public bool IsSuspended { get; private set;} = false;

    public VisaSuspended(string value, bool isSuspended)
    {
        if (isSuspended && string.IsNullOrWhiteSpace(value))
        {
            throw new ReasonOfVisaSuspendingException();
        }

        Reason = value;
        IsSuspended = isSuspended;
    }

     public void GetSuspended(string reason)
    {
        if (IsSuspended)
        {
            throw new VisaIsAlreadySuspendedException();
        }

        if (string.IsNullOrWhiteSpace(reason))
        {
            throw new ReasonOfVisaSuspendingException();
        }

        IsSuspended = true;
        Reason = reason;
    }
    
    public void Reinsiate()
    {
         if (IsSuspended)
        {
            throw new VisaIsAlreadyNotSuspendedException();
        }

        IsSuspended = false;
        Reason = string.Empty;
    }
}
