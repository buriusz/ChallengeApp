using ChallengeApp;

Console.WriteLine("Welcome to XYZ programm to evaluate Employees");
Console.WriteLine("===========================================");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Add next grade of an employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else
    {
        employee.AddGrade(input);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Ocena: {statistics.AverageLetter}");