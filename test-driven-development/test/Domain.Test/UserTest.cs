using FluentAssertions;
using Xunit;

namespace Domain.Test;

public class UserTest
{
    [Fact]
    public void CreateUser_WithValidDate_ShouldSucceed()
    {
        //Arrange
        const string name = "John Doe";
        const string email = "john.doe@gmail.com";
        const string cpf = "123.456.789-09";
        
        //Act
        var user = new User(name, email, cpf);
        
        //Assert
        user.Name.Should().Be(name);
        user.Email.Should().Be(email);
        user.Cpf.Should().Be(cpf);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("john.doe@")]
    [InlineData("john.doe@gmail")]
    public void CreateUser_WithInvalidEmail_ThrowsAnException(string invalidEmail)
    {
        //Arrange
        const string name = "John Doe";
        const string cpf = "123.456.789-09";
        
        //Act
        Func<User> createUser = () => new User(name, invalidEmail, cpf);
        
        //Assert
        createUser.Should()
            .Throw<ArgumentException>()
            .WithMessage("Email invalid.");
    }    
    
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("000.000.000-00")]
    [InlineData("085.432.125-56")]
    public void CreateUser_WithInvalidCpf_ThrowsAnException(string invalidCpf)
    {
        Func<User> createUser = () => UserBuilder.New()
            .WithCpf(invalidCpf)
            .Build();
        
        createUser.Should()
            .Throw<ArgumentException>()
            .WithMessage("Cpf invalid.");
    }
    
}