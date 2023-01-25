//Praca domowa

string name = "Sławek";
bool isMale = true;
int age = 38;


Console.WriteLine(name+" lat "+age);
if (!isMale && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
} 

if (age==33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}

if(isMale && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}



















/*
//var myAge = 38;
int myAge = 38;
myAge = int.MaxValue;
myAge = 120;
int newAge = myAge + 5;
//Console.WriteLine(newAge);
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue;
long myVar4 = long.MinValue;
ulong myVar5 = ulong.MaxValue;
ulong myVar6 = ulong.MinValue;

float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

string name = "Sławek";
string surname = "Łach";
string result = name + surname + myAge;
//Console.WriteLine(result);

char _myVar5 = 'c';
var result2 = name.ToArray();

bool isActive = true;
isActive = false;
var isValid = 5 > 6;
//Console.WriteLine(isValid);


var number1 = 5;
var number2 = 10;
if (number1 <= number2)
{
    Console.WriteLine("Jestem tutaj w linni 6");
}
else
{
    Console.WriteLine("Jestem tutaj w linni 10");
}

*/
