using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public  class EmployeeTests
    {

        [Test]
        public void ShouldReturnProperMax()
        {
            //arrange
            var user = new Employee("Sławek", "Łach");

            float score1 = 5;
            float score2 = 6;
            float score3 = 7;
            float score4 = 8;
            user.AddGrades(score1);
            user.AddGrades(score2);
            user.AddGrades(score3);
            user.AddGrades(score4);

            //act
            Statistics statistic = user.GetStatistics();
            float max = Math.Max(score1, score2);
            max = Math.Max(max, score3);
            max = Math.Max(max, score4);

            //assert
            Assert.AreEqual(max, statistic.Max);

        }

        [Test]
        public void ShouldReturnProperMin()
        {
            //arrange
            var user = new Employee("Sławek", "Łach");

            float score1 = 5;
            float score2 = 6;
            float score3 = 7;
            float score4 = 8;
            user.AddGrades(score1);
            user.AddGrades(score2);
            user.AddGrades(score3);
            user.AddGrades(score4);

            //act
            Statistics statistic = user.GetStatistics();
            float min = Math.Min(score1, score2);
            min = Math.Min(min, score3);
            min = Math.Min(min, score4);

            //assert
            Assert.AreEqual(min, statistic.Min);

        }
        [Test]
        public void ShouldReturnProperAverage()
        {
            //arrange
            var user = new Employee("Sławek", "Łach");
              
            float score1 = 5;
            float score2 = 6;
            user.AddGrades(score1);
            user.AddGrades(score2);

            //act
            Statistics statistic = user.GetStatistics();
            float avg = (score1 + score2)/2;

            //assert
            Assert.AreEqual(avg, statistic.Average);

        }
    }
}
