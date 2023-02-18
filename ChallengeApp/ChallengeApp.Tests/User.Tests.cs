using System.ComponentModel.DataAnnotations;

namespace ChallengeApp.Tests
{
    public class UserTests
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new User("S³awek",38);
            int score1 = 5;
            int score2 = 6;
     

            user.AddScore(score1);
            user.AddScore(score2);
      



            //act
            var result = user.Result;
            var sum = score1+ score2;
            //assert
            Assert.AreEqual(sum,result);


        }

        [Test]
        public void WhenUserSubtructScoreSimple_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new User("S³awek", 39);
            int score1 = 12;
            int score2 = 6;

            user.AddScore(score1);
            user.AddScore(score2);
            user.RemoveScore(score2);

            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(score1, result);
        }

        [Test]
        public void WhenUserSubtructScoreFromCol_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new User("S³awek", 39);
            int score1 = 12;
            int score2 = 6;

            user.AddScore(score1);
            user.AddScore(score2);
            user.AddScore(score2);
            user.RemoveScore(score2);

            //act
            var result = user.Result;
            var sum = score1 + score2 + score2 - score2;
            //assert
            Assert.AreEqual(sum, result);
        }


    }

}