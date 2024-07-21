namespace Strategy;

public interface ICoffee
{
    string GetProcessConfirmationMessage();
    decimal GetTotal();
    int GetPreparationTimeInMinutes();
}