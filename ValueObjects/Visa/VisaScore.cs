using Domain.Exceptions;

namespace Domain.ValueObjects;
public record VisaScore
{
    public int Score{ get; init;}

    public VisaScore(int score)
    {
        if (Score >  0 )
        {
            throw new VisaScoreException();
        }
        
        Score = score;
    }
    
    public static implicit operator int(VisaScore score) => score.Score;
    public static implicit operator VisaScore(int score) => new(score);
}
