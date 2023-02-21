namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void AreDoubleDiferentWhenDiferentValue()
        {
            //arrange
            double number1 = 2.12;
            double number2 = 3.12;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void AreDoubleTheSameWhenSameValue()
        {
            //arrange
            double number1 = 2.12;
            double number2 = 2.12;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void AreFloatDiferentWhenDiferentValue()
        {
            //arrange
            float number1 = 2.1f;
            float number2 = 3.1f;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void AreFloatTheSameWhenSameValue()
        {
            //arrange
            float number1 = 2.1f;
            float number2 = 2.1f;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void AreIntDiferentWhenDiferentValue()
        {
            //arrange
            int number1 = 2;
            int number2 = 3;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void AreIntTheSameWhenSameValue()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void AreStringTheSameWhenSameValue() {
            //arrange
            string name1 = "Sławek";
            string name2 = "Sławek";


            //act

            //assert
            Assert.AreEqual(name1, name2);    
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
