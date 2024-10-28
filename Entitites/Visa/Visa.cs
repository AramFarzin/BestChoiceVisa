using System.ComponentModel.DataAnnotations;
using Domain.Exceptions;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
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

    internal Visa(VisaId id,
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
        if (FindCondition(condition.Description) != null)
        {
            throw new ConditionAlreadyExistsException(condition.Description);
        }
        _conditionList.Add(condition);
    }

    public void Add(Requirement requirement)
    {
        if (FindRequirement(requirement.Description) != null)
        {
            throw new RequirementAlreadyExistsException(requirement.Description);
        }
        _requirementList.Add(requirement);
    }

    public void Add(Criteria criteria)
    {
        if (FindCriteria(criteria.Description) != null)
        {
            throw new CriteriaAlreadyExistsException(criteria.Description);
        }
        _criteriaList.Add(criteria);
    }
    
    public void Remove(Condition condition)
    {
        if (FindCondition(condition.Description) == null)
        {
            throw new ConditionAlreadyDoesNotExistException(condition.Description);
        }
        _conditionList.Remove(condition);
    }

    public void Remove(Requirement requirement)
    {
        if (FindRequirement(requirement.Description) == null)
        {
            throw new RequirementAlreadyDoesNotExistException(requirement.Description);
        }
        _requirementList.Remove(requirement);
    }

    public void Remove(Criteria criteria)
    {
        if (FindCriteria(criteria.Description) == null)
        {
            throw new CriteriaAlreadyDoesNotExistException(criteria.Description);
        }
        _criteriaList.Remove(criteria);
    }

    public void AddList(HashSet<Condition> collection)
    {
        foreach (var item in collection)
        {
            Add(item);        
        }
    }

    public void AddList(HashSet<Requirement> collection)
    {
        foreach (var item in collection)
        {
            Add(item);        
        }
    }

    public void AddList(HashSet<Criteria> collection)
    {
        foreach (var item in collection)
        {
            Add(item);        
        }
    }

    public Condition? FindCondition(string condition)
    {
        return _conditionList.SingleOrDefault(c => c.Description == condition);
    }

    public Requirement? FindRequirement(string requirement)
    {
        return _requirementList.SingleOrDefault(c => c.Description == requirement);
    }

    public Criteria? FindCriteria(string criteria)
    {
        return _criteriaList.SingleOrDefault(c => c.Description == criteria);
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