namespace Strategy;

public interface ICoffee
{
    decimal GetTotal();
    int GetPreparationTimeInMinutes();
    string GetProcessConfirmationMessage();
}