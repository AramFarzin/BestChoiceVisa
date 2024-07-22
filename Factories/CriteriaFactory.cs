using Domain.ValueObjects;

namespace Domain.Factories
{
    public class CriteriaFactory
    {
        public Criteria Create(string description)
        {
            // Logic for creating a valid Criteria
            return new Criteria(description);
        }
    }
}
