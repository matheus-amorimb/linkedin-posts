namespace Strategy;

public class Espresso : ICoffee
{
    public decimal GetTotal()
    {
        return 5.0m;
    }

    public int GetPreparationTimeInMinutes()
    {
        return 3;
    }

    public string GetProcessConfirmationMessage()
    {
        return $"Order confirmed: {nameof(Espresso)} \n" +
            $"Total: ${GetTotal()} \n" +
            $"Preparation Time: {GetPreparationTimeInMinutes()} minutes";
    }
}