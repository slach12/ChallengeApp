
//Praca domowa z piątego dnia
int number  = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] digits = new int[10];


foreach (char c in letters)
{  
    switch (c)
    {
        case '0':
            digits[0]++;
            break;
        case '1':
            digits[1]++;
            break;
        case '2':
            digits[2]++;
            break;
        case '3':
            digits[3]++;
            break;
        case '4':
            digits[4]++;
            break;
        case '5':
            digits[5]++;
            break;
        case '6':
            digits[6]++;
            break;
        case '7':
            digits[7]++;
            break;
        case '8':
            digits[8]++;
            break;
        case '9':
            digits[9]++;
            break;
    }
}

Console.WriteLine("Praca domowa");
Console.WriteLine($"Wynik dla liczby : {number}");

for(int index =0; index<digits.Length;index++)
{
   Console.WriteLine($"{index} => {digits[index]}");

}


