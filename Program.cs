//Werte
using System.ComponentModel.Design;
using System.Threading.Channels;
using test;

//Eingabe
string Eingabe;

//Formel
int SecPM = Year.secondPerMinute;
int SecPH = Year.secondPerHour;
int SecPD = Year.secondPerDay;
int SecPW = Year.secondPerWeek;
int SecPMo = Year.secondPerMonth;
int SecPY = Year.secondPerYear;
int MinPH = Year.minutePerHour;
int MinPD = Year.minutePerDay;
int MinPW = Year.minutePerWeek;
int MinPM = Year.minutePerMonth;
int MinPY = Year.minutePerYear;

do
{
    Console.WriteLine("Sekunden und Minuten ausrechnen, was möchtest du Wissen?");
    Console.WriteLine("Für alle Kürzel, gib einfach \"help\" und für das Verlasse \"exit\" ein.");

    Console.Write("Deine Eingabe: ");

    Eingabe = Console.ReadLine();

    if (Eingabe == "help")
    {
        Console.WriteLine("Sekunden pro Minute = SecPM \n" +
                          "Sekunden pro Stunde = SecPH \n" +
                          "Sekunden pro Tag    = SecPD \n" +
                          "Sekunden pro Woche  = SecPW \n" +
                          "Sekunden pro Monat  = SecPMo \n" +
                          "Sekunden pro Jahr   = SecPY \n" +
                          "Minuten pro Stunde  = MinPH \n" +
                          "Minuten pro Tag     = MinPD \n" +
                          "Minuten pro Woche   = MinPW \n" +
                          "Minuten pro Monat   = MinPM \n" +
                          "Minuten pro Jahr    = MinPY");
    }
    else if (Eingabe == "SecPM")
    {
        Console.WriteLine(SecPM);
    }
    else if (Eingabe == "SecPH")
    {
        Console.WriteLine(SecPH);
    }
    else if (Eingabe == "SecPD")
    {
        Console.WriteLine(SecPD);
    }
    else if (Eingabe == "SecPW")
    {
        Console.WriteLine(SecPW);
    }
    else if (Eingabe == "SecPMo")
    {
        Console.WriteLine(SecPMo);
    }
    else if (Eingabe == "SecPY")
    {
        Console.WriteLine(SecPY);
    }
    else if (Eingabe == "MinPH")
    {
        Console.WriteLine(MinPH);
    }
    else if (Eingabe == "MinPD")
    {
        Console.WriteLine(MinPD);
    }
    else if (Eingabe == "MinPW")
    {
        Console.WriteLine(MinPW);
    }
    else if (Eingabe == "MinPM")
    {
        Console.WriteLine(MinPM);
    }
    else if (Eingabe == "MinPY")
    {
        Console.WriteLine(MinPY);
    }
    else
    {
        Console.WriteLine("Falsche Angabe!");
    }


}

while (Eingabe != "exit");



