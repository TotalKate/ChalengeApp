int number = 755294;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int number0 = 0;
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        number0++;
    }
    else if (letter == '1')
    {
        number1++;
    }
    else if (letter == '2')
    {
        number2++;  
    }
    else if (letter == '3')
    {
        number3++;
    }
    else if(letter == '4')
    {
        number4++;
    }
    else if(letter == '5')
    {
        number5++;
    }
    else if(letter == '6')
    {
        number6++;
    }
    else if(letter == '7')
    {
        number7++;
    }
    else if(letter == '8')
    {
        number8++;
    }
    else if(letter == '9')
    {
        number9++;
    }
}

Console.WriteLine("0=" + number0);
Console.WriteLine("1=" + number1);
Console.WriteLine("2=" + number2);
Console.WriteLine("3=" + number3);
Console.WriteLine("4=" + number4);
Console.WriteLine("5=" + number5);
Console.WriteLine("6=" + number6);
Console.WriteLine("7=" + number7);
Console.WriteLine("8=" + number8);
Console.WriteLine("8=" + number9);