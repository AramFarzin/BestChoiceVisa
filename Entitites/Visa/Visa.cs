using System.ComponentModel.DataAnnotations;
using Domain.Exceptions;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities.Visa;
public sealed class Visa : AggregateRoot<VisaId>
{
    [Required]
    private readonly VisaType _visaType;

    [Required]
    private readonly Country _country;
        
    [Required]
    private ApplicationProcessId _applicationProcessId;
   
    [Required]
    private Money _fees;

    [Required]
    private VisaScore _minimumScore = 0;

    [Required]
    private readonly VisaSuspended _visaSuspended = new(string.Empty, false);
    
    [Required]
    private readonly HashSet<Condition> _conditionList = [];
   
    [Required]
    private readonly HashSet<Criteria> _criteriaList = [];

    [Required]
    private readonly HashSet<Requirement> _requirementList = [];

    private Visa(VisaId id,
                VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                VisaScore minimumScore)
    {
        Id = id;
        _visaType = visaType;
        _country = country;
        _applicationProcessId = applicationProcessId;
        _fees = fees;
        _minimumScore = minimumScore;
    }

    public static Visa Create(VisaId id,
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
    
    public void Edit(ApplicationProcessId applicationProcessId,
                Money fees,
                VisaScore minimumScore)
    {
        _applicationProcessId = applicationProcessId;
        _fees = fees;
        _minimumScore = minimumScore;
    }

    public void Add(Condition condition)
    {
        if (_conditionList.Contains(condition))
        {
            throw new ConditionAlreadyExistsException(condition.Description);
        }
        _conditionList.Add(condition);
    }

    public void Add(Requirement requirement)
    {
        if (_requirementList.Contains(requirement))
        {
            throw new RequirementAlreadyExistsException(requirement.Description);
        }
        _requirementList.Add(requirement);
    }

    public void Add(Criteria criteria)
    {
        if (_criteriaList.Contains(criteria))
        {
            throw new CriteriaAlreadyExistsException(criteria.Description);
        }
        _criteriaList.Add(criteria);
    }

    public void Remove(Condition condition)
    {
        if (!_conditionList.Contains(condition))
        {
            throw new ConditionAlreadyDoesNotExistException(condition.Description);
        }
        _conditionList.Remove(condition);
    }

    public void Remove(Requirement requirement)
    {
        if (!_requirementList.Contains(requirement))
        {
            throw new RequirementAlreadyDoesNotExistException(requirement.Description);
        }
        _requirementList.Remove(requirement);
    }

    public void Remove(Criteria criteria)
    {
        if (!_criteriaList.Contains(criteria))
        {
            throw new CriteriaAlreadyDoesNotExistException(criteria.Description);
        }
        _criteriaList.Remove(criteria);
    }

    public void GetSuspended(string reason)
    {
        _visaSuspended.GetSuspended(reason);
    }
    
    public void Reinsiate()
    {
        _visaSuspended.Reinsiate();
    }
}