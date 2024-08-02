using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class QuestionFactory
    {
        internal Question Create(string description)
        {
            // Logic for creating a valid Question
            return new Question(description);
        }
    }
}
