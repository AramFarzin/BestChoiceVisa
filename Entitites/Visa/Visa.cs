using System.ComponentModel.DataAnnotations;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Visa : Entity
{
    [Required]
    public VisaType VisaType { get; private set; }

    [Required]
    public Country Country { get; private set; }
        
    [Required]
    public ApplicationProcessId ApplicationProcessId { get; private set; }
   
    [Required]
    public Money Fees { get; private set;}

    [Required]
    public NoneNegativeIntegerNumber MinimumScore { get; private set;}

    [Required]
    public bool IsSuspended { get; private set;} = false;

    [Required]
    public string ReasonOfSuspending { get; private set;} = string.Empty;
    
    [Required]
    private HashSet<Condition> ConditionList { get; init; } = new();
   
    [Required]
    private HashSet<Criteria> CriteriaList { get; init; } = new();

    [Required]
    private HashSet<VisaRequirement> VisaRequirementList { get; init; } = new();

    private Visa(VisaId id,
                VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                NoneNegativeIntegerNumber minimumScore) : base(id)
    {
        VisaType = visaType;
        Country = country;
        ApplicationProcessId = applicationProcessId;
        Fees = fees;
        MinimumScore = minimumScore;
    }

    public static Visa Create(VisaId id,
                VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                NoneNegativeIntegerNumber minimumScore)
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
                NoneNegativeIntegerNumber minimumScore)
    {
        ApplicationProcessId = applicationProcessId;
        Fees = fees;
        MinimumScore = minimumScore;
    }
    
    public void Add(RequiredString conditionDescription, Question question, bool isRequired)
    {
        //create condition
        var condition = Condition.Create(conditionDescription, question, isRequired);

        ConditionList.Add(condition);
    }
    
    public void Add(Requirement requirement, NoneNegativeIntegerNumber numbers, string description)
    {
        //create requirement
        VisaRequirement visaRequirement = VisaRequirement.Create((VisaId)Id, requirement, numbers, description);

        VisaRequirementList.Add(visaRequirement);
    }

    public void Add(RequiredString description)
    {
        //create criteria
        Criteria criteria = Criteria.Create(description);

        CriteriaList.Add(criteria);
    }
    
    public void Remove(Condition condition)
    {
        ConditionList.Remove(condition);
        //delete condition
        //TODO:
    }
    
    public void Remove(VisaRequirement visaRequirement)
    {
        VisaRequirementList.Remove(visaRequirement);
        //delete requirement
        //TODO:
    }
  
    public void Remove(Criteria criteria)
    {
        CriteriaList.Remove(criteria);
        //delete criteria
        //TODO:
    }

    public void GetSuspended(string reason)
    {
        if(!IsSuspended)
        {
            ReasonOfSuspending = reason;
            IsSuspended = true;
        }
    }
    
    public void GetOpened()
    {
        if(IsSuspended)
        {
            ReasonOfSuspending = string.Empty;
            IsSuspended = false;
        }
    }
}