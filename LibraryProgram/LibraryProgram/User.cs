namespace LibraryProgram;

public class User
{
    private string userName;
    private string password;

    // Constructor
    public User(string userName, string password)
    {
        this.userName = userName;
        this.password = password;
    }
    
    // Username Getters and Setters

    public string GetUserName()
    {
        return userName;
    }

    public void SetUserName(string value)
    {
        userName = value;
    }
    
    // Books Borrowed Getters and Setters

    public string GetPassword()
    {
        return password;
    }

    public void SetPassword(string value)
    {
        password = value;
    }
}

