using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class AnswerScoreException : VisaException
{
    public AnswerScoreException(): base("The score you provided for the answer is not valid. Please ensure it is a number within the acceptable range and try again.")
    {

    }
}