using ChallengeApp;


var employee = new Employee("Sławek", "Łach");
employee.AddGrades(2000);

employee.AddGrades(2);
employee.AddGrades(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");


/*SetSth(ref statistics );
void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}*/

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}
