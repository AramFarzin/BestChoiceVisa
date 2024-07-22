using Domain.ValueObjects;

namespace Domain.Factories
{
    public class ConditionFactory
    {
        public Condition Create(string description, Question question, List<AnswerScore> asnwers, bool isRequired)
        {
            // Logic for creating a valid Condition
            return new Condition(description, question, asnwers, isRequired);
        }
    }
}
