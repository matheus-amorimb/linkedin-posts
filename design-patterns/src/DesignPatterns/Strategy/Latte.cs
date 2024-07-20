namespace Strategy;

public class Latte : ICoffee
{
    public decimal GetTotal()
    {
        return 7.5m;
    }

    public int GetPreparationTimeInMinutes()
    {
        return 4;
    }

    public string GetProcessConfirmationMessage()
    {
        return $"Order confirmed: {nameof(Latte)} \n" +
            $"Total: ${GetTotal()} \n" +
            $"Preparation Time: {GetPreparationTimeInMinutes()} minutes";
    }
}