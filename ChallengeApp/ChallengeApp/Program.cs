using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2123564318);
employee.AddGrade(30.0d);
employee.AddGrade(50);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
