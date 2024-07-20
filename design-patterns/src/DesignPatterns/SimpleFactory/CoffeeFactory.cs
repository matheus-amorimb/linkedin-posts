using Strategy;

namespace SimpleFactory;

public class CoffeeFactory
{
    public static ICoffee CreateCoffee(string coffeeType)
    {
        return coffeeType switch
        {
            "Espresso" => new Espresso(),
            "Latte" => new Latte(),
            "Iced Coffee" => new IcedCoffee(),
            _ => throw new ArgumentException("Invalid coffee type.")
        };
    }
}