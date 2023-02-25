using ChallengeApp;


var employee = new Employee("Sławek", "Łach");
employee.AddGrade(2000);

employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(7L);
employee.AddGrade(45M);
employee.AddGrade("34");
employee.AddGrade(12.33);
employee.AddGrade('C');



var statistics = employee.GetStatistics();

Console.WriteLine("GetStatistics : ");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");
