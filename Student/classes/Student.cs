namespace classes;
public class Student
{
    public string? Name { get; set; }
    public int Grade { get; set; }

    public int ListSize { get; set; }
    public List<double> TestScores { get; set; } = new List<double>();
    
    public double GetScoreAverage()
    {
        double sum = 0;
        double counter = 0;
        foreach (var score in TestScores)
        {
            sum += score;
            counter++;
        }
        return sum/counter;
    }

    public string GetPersonalizedMessage()
    {
        if(GetScoreAverage() >= 0 && GetScoreAverage() < 70)
        {
            return $"{Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is ({GetScoreAverage()}) in grade {Grade}.";
        }
        else if(GetScoreAverage() >= 70 && GetScoreAverage() < 85)
        {
            return $"Congratulations {Name} on achieving an average score of ({GetScoreAverage()}) in grade {Grade}! Keep working hard for even better results!";
        }
        else if( GetScoreAverage() >= 85 && GetScoreAverage() <= 100)
        {
            return $"Congratulations {Name} on achieving above average scores ({GetScoreAverage()}) in grade {Grade}! Keep up the good work!";
        }
        else
        {
            return string.Empty ;
        }
    }

}