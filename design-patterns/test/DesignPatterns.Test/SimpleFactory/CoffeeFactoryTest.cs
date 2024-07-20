using FluentAssertions;
using Strategy;
using Xunit;

namespace SimpleFactory.Test;

public class CoffeeFactoryTest
{
    [Fact]
    public void CoffeeFactory_WhenEspresso_ShouldReturnEspressoInstance()
    {
        var coffee = CoffeeFactory.CreateCoffee("Espresso");
        coffee.Should().BeOfType<Espresso>();
    }    
    
    [Fact]
    public void CoffeeFactory_WhenLatte_ShouldReturnLatteInstance()
    {
        var coffee = CoffeeFactory.CreateCoffee("Latte");
        coffee.Should().BeOfType<Latte>();
    }    
    
    [Fact]
    public void CoffeeFactory_WhenIcedCoffee_ShouldReturnIcedCoffeeInstance()
    {
        var coffee = CoffeeFactory.CreateCoffee("Iced Coffee");
        coffee.Should().BeOfType<IcedCoffee>();
    }
}