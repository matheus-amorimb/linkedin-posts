using SimpleFactory;

namespace Strategy;

public class ProcessCoffeeOrder
{
    public decimal Total { get; private set; } = 0;
    public int PreparationTimeInMinutes { get; private set;} = 0;
    public string ProcessConfirmationMessage { get; private set; } = "";
    private ICoffee Coffee;
    
    public void Execute(string coffeeType)
    {
        Coffee = CoffeeFactory.CreateCoffee(coffeeType);
        Console.WriteLine(Coffee.GetProcessConfirmationMessage());
    }
}

public class ProcessCoffeeOrderBeforeFactory
{
    public decimal Total { get; private set; } = 0;
    public int PreparationTimeInMinutes { get; private set;} = 0;
    public string ProcessConfirmationMessage { get; private set; } = "";
    private ICoffee Coffee;
    
    public void Execute(string coffeeType)
    {
        switch (coffeeType)
        {
            case "Espresso":
                Coffee = new Espresso();
                break;
            case "Latte":
                Coffee = new Latte();
                break;
            case "Iced Coffee":
                Coffee = new IcedCoffee();
                break;
        }
        ProcessConfirmationMessage = Coffee.GetProcessConfirmationMessage(); 
        Console.WriteLine(Coffee.GetProcessConfirmationMessage());
    }
}


public class ProcessCoffeeOrderBeforeStrategy
{
    public decimal Total { get; private set; } = 0;
    public int PreparationTimeInMinutes { get; private set;} = 0;
    public string ProcessConfirmationMessage { get; private set; } = "";
    
    public void Execute(string coffeeType)
    {
        switch (coffeeType)
        {
            case "Espresso":
                Total = 5.0m;
                PreparationTimeInMinutes = 3;
                ProcessConfirmationMessage = $"Order confirmed: {coffeeType} \n" +
                                             $"Total: ${Total} \n" +
                                             $"Preparation Time: {PreparationTimeInMinutes} minutes";
                break;
            
            case "Latte":
                Total = 7.5m;
                PreparationTimeInMinutes = 4;
                ProcessConfirmationMessage = $"Order confirmed: {coffeeType} \n" +
                                             $"Total: ${Total} \n" +
                                             $"Preparation Time: {PreparationTimeInMinutes} minutes";
                break;
            
            case "Iced Coffee":
                ProcessConfirmationMessage = "Sorry, coffee out of stock!";
                break;
        }   
        
        Console.WriteLine(ProcessConfirmationMessage);
    }
}