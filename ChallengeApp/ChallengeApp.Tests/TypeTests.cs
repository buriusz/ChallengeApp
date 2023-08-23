namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntegers_ShouldReturnEqualityOfValues()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestFloat_ShouldReturnEqualityOfValues()
        {
            // arrange
            float number1 = 1.2f;
            float number2 = 1.2f;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestDouble_ShouldReturnEqualityOfValues()
        {
            // arrange
            double number1 = 1.2d;
            double number2 = 1.2d;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestObject_ShouldntReturnEqualOfObjects()
        {
            // arrange
            var user1 = new User("Grzegorz");
            var user2 = new User("Grzegorz");

            // act

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void TestObjectLogin_ShouldReturnEqualityOfObjectsLogin()
        {
            // arrange
            var user1 = new User("Grzegorz");
            var user2 = new User("Grzegorz");

            // act

            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }


        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
