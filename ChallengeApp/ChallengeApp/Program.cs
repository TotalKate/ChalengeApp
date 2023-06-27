string imię = "Ewa";
string płeć = "Kobieta";
var wiek = 33;

if (wiek < 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (imię == "Ewa")
{
    if (wiek > 30)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}

if(płeć=="Kobieta")
{
    if (wiek<18)
    { 
        Console.WriteLine("Kobieta niepełnoletnia");
    }
    else
    {
        Console.WriteLine("Mężczyzna niepełnoletni");
    }
}
