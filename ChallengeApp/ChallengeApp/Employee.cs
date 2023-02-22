using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Employee(string name, string surname)
        {
           this.Name = name;
           this.Surname = surname;  
        }

        public void AddGrades(float grade)
        {
            this.grades.Add(grade);
        }

    }
}
