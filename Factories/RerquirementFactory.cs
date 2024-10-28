using Domain.ValueObjects;
using Domain.Entities.Visa;

namespace Domain.Factories
{
    internal class RequirementFactory
    {
        internal Requirement Create(string description, Document document, DocumentType documentType, int numbers)
        {
            return new Requirement(description, document, documentType, numbers);
        }
    }
}
