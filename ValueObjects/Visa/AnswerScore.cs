namespace Domain.ValueObjects;
using Domain.Exceptions;

public record AnswerScore
{
    public string Answer { get; init;}
    public int Score { get; init;}

    public AnswerScore(string answer, int score)
    {

       if (string.IsNullOrWhiteSpace(answer))
        {
            throw new AnswerDescriptionException();
        }

        if (score<0)
        {
            throw new AnswerScoreException();
        }
        
        Answer = new string(answer);
        Score = score;
    }
}
