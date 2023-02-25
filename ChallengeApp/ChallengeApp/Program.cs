using ChallengeApp;


var employee = new Employee("Sławek", "Łach");
employee.AddGrades(2000);

employee.AddGrades(2);
employee.AddGrades(6);
employee.AddGrades(7L);
employee.AddGrades(45M);
employee.AddGrades("34");
employee.AddGrades(12.33);



var statistics = employee.GetStatistics();

Console.WriteLine("GetStatistics : ");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");
