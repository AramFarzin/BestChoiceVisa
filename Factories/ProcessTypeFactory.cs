using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Factories
{
    internal class ProcessTypeFactory
    {
        internal ProcessType Create(string name, string description, ProcessingCenterType processingCenterType, ProcessingCenter processingCenter)
        {
            return new ProcessType(name, description, processingCenterType, processingCenter);
        }
    }
}
