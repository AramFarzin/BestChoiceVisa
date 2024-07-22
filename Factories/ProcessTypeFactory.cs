using Domain.Entities;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Factories
{
    public class ProcessTypeFactory
    {
        public ProcessType Create(string name, string description, ProcessingCenterType processingCenterType, ProcessingCenter processingCenter)
        {
            // Logic for creating a valid ProcessType
            return new ProcessType(name, description, processingCenterType, processingCenter);
        }
    }
}
