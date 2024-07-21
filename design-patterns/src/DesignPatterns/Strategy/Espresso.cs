namespace Strategy;

public class Espresso : ICoffee
{
    public decimal GetTotal() => 5.0m;
    public int GetPreparationTimeInMinutes() => 3;
    public string GetProcessConfirmationMessage()
    {
        return $"Order confirmed: {nameof(Espresso)} \n" +
            $"Total: ${GetTotal()} \n" +
            $"Preparation Time: {GetPreparationTimeInMinutes()} minutes";
    }
}