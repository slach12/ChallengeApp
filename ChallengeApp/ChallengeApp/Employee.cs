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

        public void AddGrades(long grade)
        {
            this.AddGrades((float)grade);
        }

        public void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }

        public void AddGrades(decimal grade)
        {
            this.AddGrades((float)grade);
        }

        public void AddGrades(double grade)
        {
            this.AddGrades((float)grade);

        }

        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100 )
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value.");
            }
            
        }
        public void AddGrades(string grade)
        {
            if(float.TryParse(grade,out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average+= grade;
            }

            statistics.Average/= this.grades.Count;


            return statistics;
        }
    }
}
