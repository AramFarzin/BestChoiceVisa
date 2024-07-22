using System.ComponentModel.DataAnnotations;
using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Entities;
public sealed class Visa : Entity
{
    [Required]
    public VisaType VisaType { get; private set; }
    
    [Required]
    public List<Condition> ConditionList { get; private set; }
   
    [Required]
    public List<Criteria> CriteriaList { get; private set; }

    [Required]
    public List<VisaRequirement> VisaRequirementList { get; private set; }
    
    [Required]
    public Guid ApplicationProcessId { get; private set; }
   
    [Required]
    public decimal Fees { get; private set; } = 0;

    [Required]
    public int MinimumScore { get; private set; } = 0;

    [Required]
    public bool IsSuspended { get; private set; } = false;

    [Required]
    public string ReasonOfSuspending { get; private set; } = "";

    public Visa(Guid id,
                VisaType visaType,
                Guid applicationProcessId,
                Decimal fees,
                int minimumScore) : base(id)
    {
        VisaType = visaType;
        ConditionList = new List<Condition>();
        CriteriaList = new List<Criteria>();
        VisaRequirementList = new List<VisaRequirement>();
        ApplicationProcessId = applicationProcessId;
        Fees = fees;
        MinimumScore = minimumScore;
    }
    
    public void Edit(Guid applicationProcessId,
                Decimal fees,
                int minimumScore)
    {
        ApplicationProcessId = applicationProcessId;
        Fees = fees;
        MinimumScore = minimumScore;
    } 
    
    public void AddCondition(Condition condition)
    {
        ConditionList.Add(condition);
    }
    public void AddVisaRequirement(VisaRequirement visaRequirement)
    {
        VisaRequirementList.Add(visaRequirement);
    }
    
    public void RemoveVisaRequirement(VisaRequirement visaRequirement)
    {
        VisaRequirementList.Remove(visaRequirement);
    }
    
    public void RemoveCondition(Condition condition)
    {
        ConditionList.Remove(condition);
    }
    
    public void RemoveCriteria(Criteria criteria)
    {
        CriteriaList.Remove(criteria);
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
            ReasonOfSuspending = "";
            IsSuspended = false;
        }
    }
}