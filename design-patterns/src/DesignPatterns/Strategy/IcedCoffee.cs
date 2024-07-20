namespace Strategy;

public class IcedCoffee : ICoffee
{
    public decimal GetTotal()
    {
        return 0;
    }

    public int GetPreparationTimeInMinutes()
    {
        return 0;
    }

    public string GetProcessConfirmationMessage()
    {
        return "Sorry, coffee out of stock!";
    }
}