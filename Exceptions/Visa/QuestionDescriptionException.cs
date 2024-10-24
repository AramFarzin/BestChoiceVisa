using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class QuestionDescriptionException : VisaException
{
    public QuestionDescriptionException(): base("A description for the question must be provided. Please enter a valid description.")
    {

    }
}