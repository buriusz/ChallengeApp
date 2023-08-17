using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 30);
Employee employee2 = new Employee("Monika", "Zębocka", 22);
Employee employee3 = new Employee("Zuzia", "Kawaler", 48);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);

employee3.AddScore(11);
employee3.AddScore(1);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };


int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.Name + " "+ employeeWithMaxResult.Surname + ", age: " + employeeWithMaxResult.Age + " has " + employeeWithMaxResult.Result + " points.");