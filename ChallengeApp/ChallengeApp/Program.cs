using ChallengeApp;

Console.WriteLine("Welcome to XYZ programm to evaluate Employees");
Console.WriteLine("=============================================");
Console.WriteLine("To exit type 'q' and confirm");

var employee = new Employee("Adam", "Kamizelich");
var supervisor = new Supervisor("Zenon", "Brzeczeszczykiewicz");

while (true)
{
    Console.WriteLine("Add next grade of an employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade: {statistics.AverageLetter}");