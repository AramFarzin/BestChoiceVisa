using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ConditionQuestionException : VisaException
{
    public ConditionQuestionException(): base("A question for the condition must be provided. Please enter a valid question.")
    {

    }
}