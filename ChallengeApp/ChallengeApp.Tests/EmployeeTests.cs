namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade("A");
            employee.AddGrade(7);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(0, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade("A");
            employee.AddGrade(7);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade('c');
            employee.AddGrade(7);
            employee.AddGrade('B');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(31.80f,2), Math.Round(statistics.Average), 2);
        }
    }
}