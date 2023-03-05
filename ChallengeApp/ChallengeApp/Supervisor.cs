using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => throw new NotImplementedException();

        public void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
           
           switch(grade) { 
                case var a when a == "6" :
                    this.AddGrade(100);
                    break;
                case var a when (a == "6-")|| (a == "-6"):
                    this.AddGrade(95);
                    break;
                case var a when (a == "5+") || (a == "+5"):
                    this.AddGrade(85);
                    break;
                case var a when a == "5":
                    this.AddGrade(80);
                    break;
                case var a when (a == "5-") || (a == "-5"):
                    this.AddGrade(75);
                    break;
                case var a when (a == "4+") || (a == "+4"):
                    this.AddGrade(65);
                    break;
                case var a when a == "4":
                    this.AddGrade(60);
                    break;
                case var a when (a == "4-") || (a == "-4"):
                    this.AddGrade(55);
                    break;
                case var a when (a == "3+") || (a == "+3"):
                    this.AddGrade(45);
                    break;
                case var a when a == "3":
                    this.AddGrade(40);
                    break;
                case var a when (a == "3-") || (a == "-3"):
                    this.AddGrade(35);
                    break;
                case var a when (a == "2+") || (a == "+2"):
                    this.AddGrade(25);
                    break;
                case var a when a == "2":
                    this.AddGrade(20);
                    break;
                case var a when (a == "2-") || (a == "-2"):
                    this.AddGrade(15);
                    break;
                case var a when (a == "1+") || (a == "+1"):
                    this.AddGrade(5);
                    break;
                default:
                    this.AddGrade(0);
                    break;
            }
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
