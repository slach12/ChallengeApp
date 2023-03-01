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
            user.AddGrade(score1);
            user.AddGrade(score2);
            user.AddGrade(score3);
            user.AddGrade(score4);

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
            user.AddGrade(score1);
            user.AddGrade(score2);
            user.AddGrade(score3);
            user.AddGrade(score4);

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
            user.AddGrade(score1);
            user.AddGrade(score2);
            //act
            Statistics statistic = user.GetStatistics();
            float avg = (score1 + score2)/2;
            //assert
            Assert.AreEqual(avg, statistic.Average);

        }

        [Test]
        public void ShouldReturnProperAverageLetter()
        {
            //arrange
            var user = new Employee("Sławek", "Łach");

            float score1 = 60;
            float score2 = 66;
            float score3 = 79;
            user.AddGrade(score1);
            user.AddGrade(score2);
            user.AddGrade(score3);
            //act
            Statistics statistic = user.GetStatistics();
            var avg = 'B';
            //assert
            Assert.AreEqual(avg, statistic.AverageLetter);
        }

    }
}
