using System.ComponentModel.DataAnnotations;
using Domain.Exceptions;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;

namespace Domain.Entities;
public sealed class Visa : AggregateRoot<VisaId>
{
    [Required]
    private VisaType _visaType;

    [Required]
    private Country _country;
        
    [Required]
    private ApplicationProcessId _applicationProcessId;
   
    [Required]
    private Money _fees;

    [Required]
    private VisaScore _minimumScore = 0;

    [Required]

    private VisaSuspended _visaSuspended = new VisaSuspended(string.Empty, false);
    
    [Required]
    private LinkedList<Condition> _conditionList = new();
   
    [Required]
    private LinkedList<Criteria> _criteriaList = new();

    [Required]
    private LinkedList<Requirement> _requirementList = new LinkedList<Requirement>();

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
                VisaScore minimumScore)
    {
        return new Visa(id ,
                        visaType,
                        country,
                        applicationProcessId,
                        fees,
                        minimumScore);
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
        _conditionList.AddLast(condition);
    }

    public void Add(Requirement requirement)
    {
        _requirementList.AddLast(requirement);
    }

    public void Add(Criteria criteria)
    {
        _criteriaList.AddLast(criteria);
    }

    public void Remove(Condition condition)
    {
        _conditionList.Remove(condition);        
    }

    public void Remove(Requirement requirement)
    {
        _requirementList.Remove(requirement);
    }

    public void Remove(Criteria criteria)
    {
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