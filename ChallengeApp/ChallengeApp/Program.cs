//Praca domowa

string name = "Sławek";
bool isMale = true;
int age = 38;


Console.WriteLine(name + " lat " + age);
if (!isMale && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}

if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}

if (isMale && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}


if (age == 38 && name == "Sławek")
{
    Console.WriteLine("Sławek, lat 38");
}






