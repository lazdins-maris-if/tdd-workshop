namespace EmailHandler.AI;

public interface IPredictionService
{
    (Team Team, double Confidence) PredictTeam(string emailSubject, string emailBody);
}
