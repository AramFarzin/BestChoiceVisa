using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class ConditionFactory
    {
        internal Condition Create(string description, Question question, List<AnswerScore> asnwers, bool isRequired)
        {
            // Question needs to be created
            // QuestionFactory.Create(question);

            // Answerscore needs to be created and added
            // foreach (AnswerScore answerScore in condition.Answers)
            // {
            // condition.AddAnswerAsync(answerScore);           
            // }
            // Logic for creating a valid Condition
            // return new Condition(description, question, asnwers, isRequired);
            throw new Exception();
        }
    }
}
