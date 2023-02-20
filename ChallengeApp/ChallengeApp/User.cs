using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        public User(string name,  int age) {
            this.Name = name;    
            this.Age = age;
        }

        public User(string name)
        {
            this.Name = name;
            this.Age = 0;
        }
        public string Login { get { return Name; } }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<int> scores = new List<int>();
        public void AddScore(int number)
        {
            this.scores.Add(number);
        }

        public void RemoveScore(int number)
        {
            this.scores.Remove(number);
        }
        public int Result { 
           get
            {
                return this.scores.Sum();
            } 
        }
    }
}
