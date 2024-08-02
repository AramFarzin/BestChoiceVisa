using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Domain.Services;
public class VisaService : IVisaService
{
    
    private readonly IVisaRepository _visaRepository ;
    private readonly IUnitOfWork _unitOfWork;

    public VisaService(IVisaRepository visaRepository, IUnitOfWork unitOfWork)
    {
        _visaRepository = visaRepository;
        _unitOfWork = unitOfWork;
    }

    public static int CalculateScore(IEnumerable<AnswerScore> scores)
    {
        return scores.Sum(s => s.Score);
    }

    public async Task CreateVisaAsync(VisaType visaType,
                Country country,
                ApplicationProcessId applicationProcessId,
                Money fees,
                int minimumScore)
    {
    
       await _visaRepository.AddAsync(Visa.Create(new VisaId(new Guid()), visaType, country , applicationProcessId , fees, minimumScore));
       await _unitOfWork.SavechangesAsync(CancellationToken.None);
    }

    public async Task EditAsync(Visa visa)
    {
        Visa currentVisa = await _visaRepository.GetByIdAsync(visa.Id);
        if(currentVisa == null)
        {   
            //throw Exception
            throw new Exception();
        }
        await _visaRepository.UpdateAsync(currentVisa);
        await _unitOfWork.SavechangesAsync(CancellationToken.None);
    }


    public async Task<IEnumerable<Visa>> GetVisaListAsync(IEnumerable<AnswerScore> answerScore)
    {
        // check if answerScores do exist
        var score = CalculateScore(answerScore);

        var visas = await  _visaRepository.GetAsync();
        if(visas == null || visas.Count == 0)
        {
            //throw Exception
            throw new Exception();
        }
        else
        {
            return visas.Where(v => v.MinimumScore <= score);
        }
    }

    public async Task<IEnumerable<Visa>> GetVisaListAsync(Country? country, VisaType? visaType)
    {
        var visas = await  _visaRepository.GetAsync();
        if(visas == null || visas.Count == 0)
        {
            //throw Exception
            throw new Exception();
        }
        else
        {
            return visas.Where(v => v.Country == (country ?? v.Country) && v.VisaType == (visaType ?? v.VisaType));
        }
    }
    
    public async Task ReopendAsync(VisaId id)
    {
        Visa visa = await _visaRepository.GetByIdAsync(id);
        if(visa == null)
        {   
            //throw Exception
            throw new Exception();
        }
        visa.GetOpened();
    }

    public async Task SuspendAsync(VisaId id, string reasonOfSuspending)
    {
       Visa visa = await _visaRepository.GetByIdAsync(id);
        if(visa == null)
        {   
            //throw Exception
            throw new Exception();
        }
        visa.GetSuspended(reasonOfSuspending);
    }

    public async Task<IEnumerable<Question>> GetQuestionListAsync(IEnumerable<Country>? countryList, IEnumerable<VisaType>? visaTypeList)
    {
        // TODO:
        // check if answerScores do exist
        List<Question> QuestionList = new List<Question>();

        countryList = countryList?? null;// GetAllCountries();
        visaTypeList = visaTypeList?? null;//GetAllvisaTypeList();



        foreach (var country in countryList)
        {
            foreach (var visaType in visaTypeList)
            {
                var visas = await GetVisaListAsync(country, visaType);
                
                QuestionList.AddRange(await GetQuestionListAsync(visas));
            }
        }   

        return QuestionList;     
    }

    public async Task<IEnumerable<Question>> GetQuestionListAsync(IEnumerable<Visa> visaList)
    {
        var QuestionList = new List<Question>();
        foreach (var visa in visaList)
        {
            var conditionList = await _visaRepository.GetConditionListAsync((VisaId)visa.Id);
            QuestionList.AddRange(conditionList.Select(c => c.Question));
        }

        return QuestionList;
    }
}