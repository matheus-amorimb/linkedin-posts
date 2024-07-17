namespace Refactoring;

public class ReplaceNestedConditional
{
    public void SignUp(User user)
    {
        if (user != null)
        {
            if (isValidFullName(user.FullName))
            {
                if (isValidEmail(user.Email))
                {
                    if (isValidPassword(user.Password))
                    {
                        Console.WriteLine("User registered successfully.");
                    }
                    else
                    {
                        throw new ArgumentException("Password is invalid.");    
                    }
                }
                else
                {
                    throw new ArgumentException("Email is invalid.");    
                }
            }
            else
            {
                throw new ArgumentException("Name is invalid.");
            }   
        }
        else
        {
            throw new ArgumentException("User is null.");
        }
    }

    public void SignUpRefactored(User user)
    {
        if(user == null) 
            throw new ArgumentException("User is null.");
        if (!isValidFullName(user.FullName)) 
            throw new ArgumentException("Name is invalid.");
        if (!isValidEmail(user.Email)) 
            throw new ArgumentException("Email is invalid.");
        if (!isValidPassword(user.Password)) 
            throw new ArgumentException("Password is invalid.");
        Console.WriteLine("User registered successfully.");
    }

    private bool isValidPassword(object password)
    {
        throw new NotImplementedException();
    }

    private bool isValidEmail(object email)
    {
        throw new NotImplementedException();
    }

    private bool isValidFullName(object fullName)
    {
        throw new NotImplementedException();
    }
}

public class User
{
    public User(object fullName, object email, object password)
    {
        FullName = fullName;
        Email = email;
        Password = password;
    }

    public object FullName { get; set; }
    public object Email { get; set; }
    public object Password { get; set; }
}