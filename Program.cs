// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

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


//Achte Übungsaufgabe
/*
string [] producst = new string [4];
producst[0] = "Wasserfalsche";
producst[1] = "Kaugummi";
producst[2] = "Nudeln";
producst[3] = "Kartoffeln";


string [] producst = new string [] 
{
    "Wasserfalsche", 
    "Kaugummi", 
    "Nudeln", 
    "Kartoffeln",
    "Bananen"
};

Console.WriteLine(producst[0]);
Console.ReadKey();
*/


//Neunte Übungsaufgabe
/*
string [,] names = new string [4, 2];

//1 Zeile
names[0, 0] = "Max";
names[0, 1] = "Mustermann";

//2 Zeile
names[1, 0] = "Erika";
names[1, 1] = "Musterfrau";

//3 Zeile
names[2, 0] = "Hans";
names[2, 1] = "Müller";

//4 Zeile
names[3, 0] = "Peter";
names[3, 1] = "Schmidt";


string [,] names = new string [,]
{
    {"Max", "Mustermann"},
    {"Erika", "Musterfrau"},
    {"Hans", "Müller"},
    {"Peter", "Schmidt"}
};

Console.WriteLine(names[0, 0] + " " + names[0, 1]);
Console.WriteLine(names[1, 0] + " " + names[1, 1]);
Console.WriteLine(names[2, 0] + " " + names[2, 1]);
Console.WriteLine(names[3, 0] + " " + names[3, 1]);
Console.ReadKey();
*/


//Zehnte Übungsaufgabe
/*
Console.WriteLine("Gib eine Zahl ein:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib eine zweite Zahl ein:");
int number2 = Convert.ToInt32(Console.ReadLine());

while (number <= number2)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number++;
}

Console.ReadKey();
*/


//Elfte Übungsaufgabe
/*
bool isNumber = true;

while (isNumber == true)
{

Console.WriteLine("Gib eine Zahl ein:");
int number = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine("Gib eine zweite Zahl ein:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib den Rechenoperator ein:");
string math = Console.ReadLine();

    switch (math)
    {
        case "+":
            Console.WriteLine("{0} + {1} = {2}", number, number2, number + number2);
            isNumber = false;
            break;
        case "-":
            Console.WriteLine("{0} - {1} = {2}", number, number2, number - number2);
            isNumber = false;
            break;
        case "*":
            Console.WriteLine("{0} * {1} = {2}", number, number2, number * number2);
            isNumber = false;
            break;
        case "/":
            Console.WriteLine("{0} / {1} = {2}", number, number2, number / number2);
            isNumber = false;
            break;
        case "%":
            Console.WriteLine("{0} % {1} = {2}", number, number2, number % number2);
            isNumber = false;
            break;
        default:
            Console.WriteLine("Ungültige Eingabe");
            isNumber = false;
            break;
    }
    Console.ReadKey();
    Console.Clear();
    isNumber = true;
}
*/


//Zwölfte Übungsaufgabe
/*
Console.WriteLine("Gib eine Zahl ein:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
}
Console.ReadKey();
*/

//Dreizehnte Übungsaufgabe
/*
Console.WriteLine("Gib die breite an:");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib die höhe an:");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.ReadKey();
*/


//Vierzehnte Übungsaufgabe
/*
for ( int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write("{0} x {1} = {2}\t", i, j, i * j);
    }
        for (int k = 1; k <= 10; k++)
        {
            Console.CursorLeft = 20;
        }
    Console.WriteLine();
}
Console.ReadKey();
*/


//Fünfzehnte Übungsaufgabe
/*
Console.WriteLine("Gib einen Satz ein:");
string sentence = Console.ReadLine();
string[] words = sentence.Split(char.Parse(" "));

for (int i = 0; i < words.Length; i++)
{
    for (int j = 0; j < words[i].Length; j++)
    {
        Console.WriteLine(words[i][j]);
    }
    Console.WriteLine();
}
Console.ReadKey();
*/



//Sechzehnte Übungsaufgabe
/*
Console.WriteLine("Gib ein Wort ein:");
string word = Console.ReadLine().ToLower();
string reverse = "".ToLower();

for (int i = word.Length - 1; i >= 0; i--)
{
    reverse += word[i];
}

if (word == reverse)
{
    Console.WriteLine("Das Wort ist ein Palindrom");
}
else
{
    Console.WriteLine("Das Wort ist kein Palindrom");
}
Console.ReadKey();
*/

/*
MainMenu();


static void MainMenu() {

Console.WriteLine("Willkommen zum Hangman Spiel!");
Console.WriteLine();
Console.WriteLine("Wähle eine Option:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1. Spiel starten");
Console.WriteLine("2. Spiel beenden");
Console.ResetColor();
Console.WriteLine();
Console.Write("Deine Auswahl: ");
int choice = Convert.ToInt32(Console.ReadLine());
bool EndGame = false;

switch (choice)
{
    case 1:
        StartGame();
        break;
    case 2:
        EndGame = true;
        break;
    default:
        Console.WriteLine("Ungültige Eingabe");
        break;
}

if (EndGame){
    return;
    }
Console.Clear();
}

static void StartGame(){
    string[] words = new string[]
    {
        "apfel",
        "birne",
        "banane",
        "kiwi",
        "ananas",
        "mango",
        "kirsche",
        "pflaume",
        "erdbeere",
        "himbeere"
    };

    Random rnd = new Random();
    int index = rnd.Next(0, words.Length);
    string word = words[index].ToLower();
    GameLoop(word);
}

static void GameLoop(string word){

    int lives = 10;
    string hiddenWord = "";

    for (int i = 0; i < word.Length; i++)
    {
        hiddenWord += "_";
    }

    while (true) {
        Console.Clear();
        Console.WriteLine("Gesuchtes Wort: " + hiddenWord);

        Console.Write("noch übrige Versuche: ");
        for (int i = 0; i < lives; i++)
        {
            Console.Write("❤️");
        }

        Console.WriteLine();
        Console.Write("Gib einen Buchstaben ein:");
        char Character = Convert.ToChar(Console.ReadLine().ToLower());

        bool foundCharacterInWords = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == Character)
            {
                foundCharacterInWords = true;
                break;
            }
        }
    
        string TempHiddenWord = hiddenWord;
        hiddenWord = "";

        if (foundCharacterInWords)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == Character)
                {
                    hiddenWord += Character;
                }
                else if (TempHiddenWord[i] != '_')
                {
                    hiddenWord += TempHiddenWord[i];
                }
                else
                {
                    hiddenWord += "_";
                }
            }
        }

        if (hiddenWord == word)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gesuchtes Wort: " + hiddenWord);
            Console.WriteLine("Herzlichen Glückwunsch! Du hast das Wort erraten!");
            Console.ReadKey();
            Console.ResetColor();
            break;
        }
        else 
        {
            hiddenWord = TempHiddenWord;
            
            if  (lives > 0)
            {
                lives--;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Gesuchtes Wort: " + word);
                Console.WriteLine("Du hast keine Leben mehr übrig! Das Spiel ist vorbei!");
                Console.ReadKey();
                Console.ResetColor();
                break;
            }
        }

    }
}*/
