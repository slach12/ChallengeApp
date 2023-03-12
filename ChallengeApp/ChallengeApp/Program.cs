using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var emInFile = new EmployeeInFile("Sławek", "Łach");
emInFile.AddGrade(2.4f);
emInFile.AddGrade(3.4f);
emInFile.AddGrade(2.6f);

var statistics = emInFile.GetStatistics();
Console.WriteLine($"Average : {statistics.Average}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");

var EmpInMem = new EmployeeInMemory("Sławek", "Łach");
EmpInMem.GradeAdded += EmpInMem_GradeAdded;
EmpInMem.GradeAdded += EmpInMem_GradeAdded;
EmpInMem.GradeAdded += EmpInMem_GradeAdded;

EmpInMem.AddGrade(0.6f);
EmpInMem.GradeAdded -= EmpInMem_GradeAdded;
EmpInMem.AddGrade(0.6f);

void EmpInMem_GradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano nową ocenę.");
}

try
{
    Employee emp = null;
}
catch (Exception ex)
{
    Console.WriteLine($"Tego nie powinno być. {ex.Message}");
}
finally
{
    Console.WriteLine("Finally is here.");
}
/*while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    { 
        employee.AddGrade(input); 
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average : {statistics.Average}");
Console.WriteLine($"Min : {statistics.Min}"); 
Console.WriteLine($"Max : {statistics.Max}");*/