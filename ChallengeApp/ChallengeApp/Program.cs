

int[] grades = new int[5];

//string[] dayOfWeeks = new string[7];
List<string> dayOfWeeks = new List<string>
{
    "Poniedziałek",
    "Wtorek",
    "Środa",
    "Czwartek",
    "Piątek",
    "Sobota",
    "Niedziela"
};

Console.WriteLine(dayOfWeeks[2]);

string[] weekdays = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };

Console.WriteLine(weekdays[0]);

/*for(int i = 0;i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
*/

foreach(var day in dayOfWeeks)
{
    Console.WriteLine(day);
}


