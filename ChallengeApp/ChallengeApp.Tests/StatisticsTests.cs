using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void IsMaxReturn()
        {
            //arrange
            var statistic = new Statistics();



            //act
            statistic.Max = 5;


            //assert
            Assert.AreEqual(5,statistic.Max);

        }
    }
}
