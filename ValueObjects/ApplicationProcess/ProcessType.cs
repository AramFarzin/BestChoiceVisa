using Domain.Entities;

namespace Domain.ValueObjects;
public record ProcessType(RequiredString Name, RequiredString Description, ProcessingCenterType ProcessingCenterType, ProcessingCenter ProcessingCenter);
