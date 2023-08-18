

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            // arrange

            var employee = new Employee("Adam", "Kowalski", 30);
            employee.AddScore(5);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenUserCollectThreeScores_ShouldReturnCorrectResult()
        {
            // arrange

            var employee = new Employee("Adam", "Dawidof", 32);
            employee.AddScore(5);
            employee.AddPenaltyScore(11);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenUserCollectFiveScores_ShouldReturnCorrectResult()
        {
            // arrange

            var employee = new Employee("Adam", "Dawidof", 32);
            employee.AddScore(5);
            employee.AddPenaltyScore(2);
            employee.AddScore(6);
            employee.AddScore(1);
            employee.AddPenaltyScore(8);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(2, result);
        }
    }
}