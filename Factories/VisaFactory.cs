using Domain.Entities;
using Domain.ValueObjects;

public sealed class  VisaFactory : IVisaFactory
{
    public Visa Create(VisaId id,
                VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                VisaScore minimumScore,
                IEnumerable<Condition>? conditionList,
                IEnumerable<Requirement>? requirementList,
                IEnumerable<Criteria>? criteriaList)
    {
        var visa = new Visa(id ,
                        visaType,
                        country,
                        applicationProcessId,
                        fees,
                        minimumScore);

        if (conditionList != null) foreach (var condition in conditionList) visa.Add(condition);
        if (requirementList != null) foreach (var condition in requirementList) visa.Add(condition);
        if (criteriaList != null) foreach (var condition in criteriaList) visa.Add(condition);
        
        return visa;
    }
}