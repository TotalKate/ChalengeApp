using System.ComponentModel.Design;

string name = "Ewa";
bool female = false;
var age = 17;

if (female)
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}

else
{
    if (age>18 && !female)
    {
        Console.WriteLine("Mężczyzna pełnoletni");
    }
    else if(age<18 && !female)
    {
        Console.WriteLine("Mężczyzna niepełnoletni");
    }
}
    