namespace Domain.Test;

public class UserBuilder
{
    private string _name { get; set; } = "John Doe";
    private string _email { get; set; } = "john.doe@gmail.com";
    private string _cpf { get; set; } = "123.456.789-09";

    public static UserBuilder New()
    {
        return new UserBuilder();
    }

    public UserBuilder WithName(string name)
    {
        _name = name;
        return this;
    }    
    
    public UserBuilder WithEmail(string email)
    {
        _email= email;
        return this;
    }    
    
    public UserBuilder WithCpf(string cpf)
    {
        _cpf = cpf;
        return this;
    }
    
    public User Build()
    {
        return new User(_name, _email, _cpf);
    }
    
}