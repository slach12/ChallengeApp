using System.Globalization;

User user1 = new User("Adam");
User user2 = new User("Zuzia");
User user3 = new User("Damian");
User user4 = new User("Monika");


class User
{
    
  

    public string Login { get; private set; }
    public string Password { get; private set; }
    public User()
    {
        this.Login = "-";
        this.Password = "-";
            
    }
    public User(string loign)
    {
        Login = loign;
    }
    public User(string login, string pasword) {
        Login = login;
        Password = pasword;
    }
}

