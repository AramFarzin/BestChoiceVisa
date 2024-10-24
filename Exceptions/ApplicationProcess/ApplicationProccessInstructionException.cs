using Shared.Abstraction.Exceptions;

namespace Domain.Exceptions;
public class ApplicationProccessInstructionException : ApplicationProccessException
{
    public ApplicationProccessInstructionException(): base("Instruction can not be null or empty")
    {
    }
}