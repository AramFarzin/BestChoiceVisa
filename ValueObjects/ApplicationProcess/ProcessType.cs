using Domain.Entities;
using Domain.Primitives;

namespace Domain.ValueObjects;
public record ProcessType(string Name, string Description, ProcessingCenterType ProcessingCenterType, ProcessingCenter ProcessingCenter);