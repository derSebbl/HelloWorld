// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

// Erste Übungsaufgabe
Console.WriteLine("Hello, Whats your First Name?");
string firstName = Console.ReadLine();
Console.WriteLine("and your last name?");
string lastName = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + firstName + " " + lastName + " Welcome Back!");
Console.WriteLine("Hello {0} {1} Welcome Back!", firstName, lastName);


//Zweite Übungsaufgabe
Console.WriteLine("Gebe mir bitte eine Zahl zwischen 1 und 10?");
double zahl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("und jetzt bitte eine zweite");
double zahl2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0} + {1} = {2}", zahl, zahl2, zahl + zahl2);
Console.WriteLine("{0} - {1} = {2}", zahl, zahl2, zahl - zahl2);
Console.WriteLine("{0} * {1} = {2}", zahl, zahl2, zahl * zahl2);
Console.WriteLine("{0} / {1} = {2}", zahl, zahl2, zahl / zahl2);
Console.WriteLine("{0} % {1} = {2}", zahl, zahl2, zahl % zahl2);