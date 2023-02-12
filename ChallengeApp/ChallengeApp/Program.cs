using System.Globalization;
using ChallengeApp;
User user1 = new User("Sławek",38);
User user2 = new User("Piotrek",32);
User user3 = new User("Adam",30);
user1.AddScore(1);
user1.AddScore(2);
user1.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(6);
user3.AddScore(7);
user3.AddScore(8);
user3.AddScore(9);
List<User> users = new List<User>();
users.Add(user1);
users.Add(user2);
users.Add(user3);

var bestUser = user1;
foreach(var user in users)
{
  if (user.Result> bestUser.Result)
    {
        bestUser = user;
    } 
}
Console.WriteLine($"Najlepszy wynik ma użytkownik {bestUser.Name} : {bestUser.Result} punkty.");

