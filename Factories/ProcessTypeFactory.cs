using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class ProcessTypeFactory
    {
        internal ProcessType Create(RequiredString name, RequiredString description, ProcessingCenterType processingCenterType, ProcessingCenter processingCenter)
        {
            // Logic for creating a valid ProcessType
            return new ProcessType(name, description, processingCenterType, processingCenter);
        }
    }
}
