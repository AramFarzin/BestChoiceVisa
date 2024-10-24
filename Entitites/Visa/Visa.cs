using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
using Shared.Abstraction.Domain;
using Shared.Abstraction.Primitives;

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
    private Money _fees = new("EURO", 0);

    [Required]
    private VisaScore _minimumScore = 0;

    [Required]

    private VisaSuspended _visaSuspended = new VisaSuspended(string.Empty, false);
    
    [Required]
    private LinkedList<Condition> _conditionList = new();
   
    [Required]
    private LinkedList<Criteria> _criteriaList = new();

    [Required]
    private LinkedList<VisaRequirement> _visaRequirementList = new();

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
    
    public void Add(string conditionDescription, Question question, bool isRequired)
    {
        //create condition
        var condition = Condition.Create(conditionDescription, question, isRequired);

        _conditionList.AddLast(condition);
    }
    
    public void Add(Requirement requirement, int numbers, string description)
    {
        //create requirement
        VisaRequirement visaRequirement = VisaRequirement.Create((VisaId)Id, requirement, numbers, description);

        _visaRequirementList.AddLast(visaRequirement);
    }

    public void Add(string description)
    {
        //create criteria
        Criteria criteria = Criteria.Create(description);

        _criteriaList.AddLast(criteria);
    }
    
    public void Remove(Condition condition)
    {
        _conditionList.Remove(condition);
        //delete condition
        //TODO:
    }
    
    public void Remove(VisaRequirement visaRequirement)
    {
        _visaRequirementList.Remove(visaRequirement);
        //delete requirement
        //TODO:
    }
  
    public void Remove(Criteria criteria)
    {
        _criteriaList.Remove(criteria);
        //delete criteria
        //TODO:
    }

    public void GetSuspended(string reason)
    {
        _visaSuspended.GetSuspended(reason);
    }
    
    public void GetOpened()
    {
        _visaSuspended.GetOpened();
    }
}