using System.Collections.Immutable;
using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class ConditionFactory
    {
        internal Condition Create(string conditionDescription, string questionDescription, Dictionary<string, int> answers, bool isRequired)
        {
            Condition condition = new Condition(conditionDescription, questionDescription, ToAnswerScoreList(answers), isRequired);

            return condition;
        }

        private static ImmutableArray<AnswerScore> ToAnswerScoreList(Dictionary<string, int> pairs) => pairs.Select(p=> new AnswerScore(p.Key,p.Value)).ToImmutableArray();
    }
}
