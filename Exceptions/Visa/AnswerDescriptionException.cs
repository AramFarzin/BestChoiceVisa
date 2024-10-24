using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class AnswerDescriptionException : VisaException
{
    public AnswerDescriptionException(): base("A description for the answer must be provided. Please enter a valid description.")
    {

    }
}