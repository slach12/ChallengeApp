namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST() {
            //arrange
            string number1 = "Sławek";
            string number2 = "Sławek";


            //act

            //assert
            Assert.AreEqual(number1, number2);    
        }

        [Test]
        public void GetUserShouldReturnDifferentObject()
        {
            //arrange
            var user1 = GetUser("Sławek");
            var user2 = GetUser("Sławek");
            //act
   
            //assert
            Assert.AreNotEqual(user1,user2);
            
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
