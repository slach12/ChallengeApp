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
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("GetStatistics : ");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");

Console.WriteLine("GetStatisticsWithForEach : ");
Console.WriteLine($"Average : {statistics1.Average:N2}");
Console.WriteLine($"Min : {statistics1.Min}");
Console.WriteLine($"Max : {statistics1.Max}");

Console.WriteLine("GetStatisticsWithFor : ");
Console.WriteLine($"Average : {statistics2.Average:N2}");
Console.WriteLine($"Min : {statistics2.Min}");
Console.WriteLine($"Max : {statistics2.Max}");

Console.WriteLine("GetStatisticsWithDoWhile : ");
Console.WriteLine($"Average : {statistics3.Average:N2}");
Console.WriteLine($"Min : {statistics3.Min}");
Console.WriteLine($"Max : {statistics3.Max}");

Console.WriteLine("GetStatisticsWithWhile : ");
Console.WriteLine($"Average : {statistics4.Average:N2}");
Console.WriteLine($"Min : {statistics4.Min}");
Console.WriteLine($"Max : {statistics4.Max}");


/*SetSth(ref statistics );
void SetSth(ref Statistics statistics)
{
    statistics = new Statistics();
}*/

/*SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}
*/