using System.Globalization;

User user1 = new User("Adam");
User user2 = new User("Zuzia");
User user3 = new User("Damian");
User user4 = new User("Monika");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;



class User
{
    //private int score =0;

    public static string GameName = "Diablo";

    private List<int> score = new List<int>();
    

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

    public int Result { 
        get {
            return this.score.Sum();
        } 
    
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }

}

