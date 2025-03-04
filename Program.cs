// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

// Erste Übungsaufgabe
/*Console.WriteLine("Hello, Whats your First Name?");
string firstName = Console.ReadLine();
Console.WriteLine("and your last name?");
string lastName = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + firstName + " " + lastName + " Welcome Back!");
Console.WriteLine("Hello {0} {1} Welcome Back!", firstName, lastName);*/


//Zweite Übungsaufgabe
/*Console.WriteLine("Gebe mir bitte eine Zahl zwischen 1 und 10?");
double zahl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("und jetzt bitte eine zweite");
double zahl2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0} + {1} = {2}", zahl, zahl2, zahl + zahl2);
Console.WriteLine("{0} - {1} = {2}", zahl, zahl2, zahl - zahl2);
Console.WriteLine("{0} * {1} = {2}", zahl, zahl2, zahl * zahl2);
Console.WriteLine("{0} / {1} = {2}", zahl, zahl2, zahl / zahl2);
Console.WriteLine("{0} % {1} = {2}", zahl, zahl2, zahl % zahl2);*/


//Dritte Übungsaufgabe
/* GetTextInput("Gib deinen Vornamen ein:");

static void GetTextInput(string message)
{
   Console.WriteLine(message);
    string firstName = Console.ReadLine();
    Console.WriteLine("Gib deinen Nachnamen ein:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Hallo {0} {1}!", firstName, lastName);
} */


//Vierte Übungsaufgabe
/* Console.WriteLine("Gib einen Radius ein:");
double radius = Convert.ToDouble(Console.ReadLine());
double area = GetCircleArea(radius);
Console.WriteLine("Der Flächeninhalt des Kreises mit einem Radius von {0}cm beträgt: {1}", radius, area);
static double GetCircleArea(double radius)
{
    double PI = Math.PI;
    double A = PI * radius * radius;
    return A;
}*/