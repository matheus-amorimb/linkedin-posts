using System.Text.RegularExpressions;

namespace Domain;

public class User
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Cpf { get; private set; }

    public User(string name, string email, string cpf)
    {
        Name = ValidateName(name);
        Email = ValidateEmail(email);
        Cpf = ValidateCpf.Execute(cpf);
    }

    private string ValidateName(string name)
    {
        var namePattern = @"^[a-zA-Z]+ [a-zA-Z]+$";
        if(!Regex.IsMatch(name, namePattern)) throw new ArgumentException("Name invalid.");
        return name;
    }
    private string ValidateEmail(string email)
    {
        var emailPattern = @"^[\w-\.]+\@([\w-]+\.)+[\w-]{2,4}$";
        if(string.IsNullOrEmpty(email)) throw new ArgumentException("Email invalid.");
        if(!Regex.IsMatch(email, emailPattern)) throw new ArgumentException("Email invalid.");
        return email;
    }
}