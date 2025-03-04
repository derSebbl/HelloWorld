// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

// Erste Übungsaufgabe
/*
Console.WriteLine("Hello, Whats your First Name?");
string firstName = Console.ReadLine();
Console.WriteLine("and your last name?");
string lastName = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + firstName + " " + lastName + " Welcome Back!");
Console.WriteLine("Hello {0} {1} Welcome Back!", firstName, lastName);
*/


//Zweite Übungsaufgabe
/*
Console.WriteLine("Gebe mir bitte eine Zahl zwischen 1 und 10?");
double zahl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("und jetzt bitte eine zweite");
double zahl2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0} + {1} = {2}", zahl, zahl2, zahl + zahl2);
Console.WriteLine("{0} - {1} = {2}", zahl, zahl2, zahl - zahl2);
Console.WriteLine("{0} * {1} = {2}", zahl, zahl2, zahl * zahl2);
Console.WriteLine("{0} / {1} = {2}", zahl, zahl2, zahl / zahl2);
Console.WriteLine("{0} % {1} = {2}", zahl, zahl2, zahl % zahl2);
*/


//Dritte Übungsaufgabe
/* 
GetTextInput("Gib deinen Vornamen ein:");

static void GetTextInput(string message)
{
   Console.WriteLine(message);
    string firstName = Console.ReadLine();
    Console.WriteLine("Gib deinen Nachnamen ein:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Hallo {0} {1}!", firstName, lastName);
} 
*/


//Vierte Übungsaufgabe
/* 
Console.WriteLine("Gib einen Radius ein:");
double radius = Convert.ToDouble(Console.ReadLine());
double area = GetCircleArea(radius);
Console.WriteLine("Der Flächeninhalt des Kreises mit einem Radius von {0}cm beträgt: {1}", radius, area);
static double GetCircleArea(double radius)
{
    double PI = Math.PI;
    double A = PI * radius * radius;
    return A;
}
*/


//Fünfte Übungsaufgabe
/* 
Console.WriteLine("Gib dein Gewicht in KG ein:");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Gib deine Größe in Meter ein:");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = GetBMI(weight, height);

static double GetBMI(double weight, double height)
{
    double bmi = weight / (height * height);
    return bmi;
}


if (bmi < 18.5)
{
    Console.WriteLine("Untergewicht");
}
else if (bmi >= 18.5 && bmi < 24.9)
{
    Console.WriteLine("Normalgewicht");
}
else if (bmi >= 25 && bmi < 29.9)
{
    Console.WriteLine("Übergewicht");
}
else if (bmi >= 30 && bmi < 34.9)
{
    Console.WriteLine("Adipositas Grad 1");
}
else if (bmi >= 35 && bmi < 39.9)
{
    Console.WriteLine("Adipositas Grad 2");
}
else if (bmi >= 40)
{
    Console.WriteLine("Adipositas Grad 3");
} 
*/


//Sechste Übungsaufgabe
/*
Console.WriteLine("Gib eine Jahreszahl ein:");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("Das Jahr {0} ist ein Schaltjahr", year);
}
else
{
    Console.WriteLine("Das Jahr {0} ist kein Schaltjahr", year);
}
*/


//Siebte Übungsaufgabe
/*
Console.WriteLine("Gib eine Zahl ein:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib einen Mathematisches Zeichen ein:");
string math = Console.ReadLine();
Console.WriteLine("Gib eine zweite Zahl ein:");
int number2 = Convert.ToInt32(Console.ReadLine());

switch (math)
{
    case "+":
        Console.WriteLine("{0} + {1} = {2}", number, number2, number + number2);
        break;
    case "-":
        Console.WriteLine("{0} - {1} = {2}", number, number2, number - number2);
        break;
    case "*":
        Console.WriteLine("{0} * {1} = {2}", number, number2, number * number2);
        break;
    case "/":
        Console.WriteLine("{0} / {1} = {2}", number, number2, number / number2);
        break;
    case "%":
        Console.WriteLine("{0} % {1} = {2}", number, number2, number % number2);
        break;
    default:
        Console.WriteLine("Ungültige Eingabe");
        break;
}
*/

