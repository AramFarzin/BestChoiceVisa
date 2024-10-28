using Domain.Entities;
using Domain.ValueObjects;

public interface IVisaFactory
{
    Visa Create(VisaId id,
                VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                VisaScore minimumScore,
                IEnumerable<Condition>? conditionList,
                IEnumerable<Requirement>? requirementList,
                IEnumerable<Criteria>? criteriaList);
}