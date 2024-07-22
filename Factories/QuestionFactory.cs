using Domain.ValueObjects;

namespace Domain.Factories
{
    public class QuestionFactory
    {
        public Question Create(string description)
        {
            // Logic for creating a valid Question
            return new Question(description);
        }
    }
}
