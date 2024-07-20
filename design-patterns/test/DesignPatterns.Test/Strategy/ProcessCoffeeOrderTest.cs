using FluentAssertions;
using Strategy;
using Xunit;

namespace SimpleFactoryTest;

public class ProcessCoffeeOrderTest
{
    [Fact]
    public void ProcessOrder_ForEspresso_Successfully()
    {
        var processOrder = new ProcessCoffeeOrder();
        processOrder.Execute("Espresso");
        processOrder.ProcessConfirmationMessage.Should().Be("Order confirmed: Espresso \n" +
                                                            $"Total: $5.0 \n" +
                                                            $"Preparation Time: 3 minutes");
    }    
    
    [Fact]
    public void ProcessOrder_ForLatte_Successfully()
    {
        var processOrder = new ProcessCoffeeOrder();
        processOrder.Execute("Latte");
        processOrder.ProcessConfirmationMessage.Should().Be("Order confirmed: Latte \n" +
                                                            $"Total: $7.5 \n" +
                                                            $"Preparation Time: 4 minutes");
    }    
    
    [Fact]
    public void ProcessOrder_ForIcedCoffee_Successfully()
    {
        var processOrder = new ProcessCoffeeOrder();
        processOrder.Execute("Iced Coffee");
        processOrder.ProcessConfirmationMessage.Should().Be("Sorry, coffee out of stock!");
    }
}