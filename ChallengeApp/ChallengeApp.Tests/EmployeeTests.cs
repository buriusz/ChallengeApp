namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserGivesOneZeroGrade_ShouldReturnZeroMinMaxAverageValue()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(0f, statistics.Min);
            Assert.AreEqual(0f, statistics.Max);
            Assert.AreEqual(0f, statistics.Average);
        }

        [Test]
        public void TestMinValue()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade(7);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(0, statistics.Min);
        }

        [Test]
        public void TestMaxValue()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade(7);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(12, statistics.Max);
        }

        [Test]
        public void TestAverageValue()
        {
            var employee = new Employee("Adam", "Dawidof");
            employee.AddGrade(0);
            employee.AddGrade(12);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(6f, statistics.Average);
        }
    }
}