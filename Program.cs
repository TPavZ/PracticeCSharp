// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello!");

string fA = "Tyler";
string fB = "Taylor";
string fC = "Tim";

Console.WriteLine($"Hello {fB} & {fC}! From, {fA}");
Console.WriteLine(
    $"Just so you know, {fB} your name has {fB.Length} letters & {fC} your name has {fC.Length} letters."
);

//Suppose your strings have leading or trailing spaces that you don't want to display. You want to trim the spaces from the strings. The Trim method and related methods TrimStart and TrimEnd do that work. You can just use those methods to remove leading and trailing spaces. Try the following code
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

//The square brackets [ and ] help visualize what the Trim, TrimStart and TrimEnd methods do. The brackets show where whitespace starts and ends.
string trimGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimGreeting}]");

// Do not have to add "string" to redefine a variable
trimGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimGreeting}]");
trimGreeting = greeting.Trim();
Console.WriteLine($"[{trimGreeting}]");

string sayHello = "Hello Peeps!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Bye");
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Peeps!", "World");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songA = "You say goodbye, and I say hello";

//Returns boolean
Console.WriteLine(songA.Contains("goodbye"));
Console.WriteLine(songA.Contains("greetings"));
bool test = songA.Contains("say");
if (test == false)
{
    Console.WriteLine("This is not in this song!");
}
;
if (test == true)
{
    Console.WriteLine("That word is in the song!");
}
;
Console.WriteLine(songA.StartsWith("You"));
Console.WriteLine(songA.StartsWith("goodbye"));

Console.WriteLine(songA.EndsWith("and"));
Console.WriteLine(songA.EndsWith("hello"));

int a = 15;
int b = 5;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c = a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);

int a1 = 5;
int b1 = 4;
int c1 = 2;
int d1 = a1 + b1 + c1;
Console.WriteLine(d1);

d1 = (a1 + b1) * c1;
Console.WriteLine(d1);
d1 = a1 + b1 - 6 * c1 + (12 * 4) / 3 + 12;
Console.WriteLine(d1);

int a2 = 7;
int b2 = 4;
int c2 = 3;
int d2 = (a2 + b2) / c2;
int e2 = (a2 + b2) % c2;
Console.WriteLine($"quotient: {d2}");
Console.WriteLine($"remainder: {e2}");

//The C# integer type differs from mathematical integers in one other way: the int type has minimum and maximum limits. Run this code in the interactive window to see those limits
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range on integers is {max} to {min}");

int what = max + 3;
Console.WriteLine($"An example of overlow: {what}");

//Notice that the answer is very close to the minimum (negative) integer. It's the same as min + 2. The addition operation overflowed the allowed values for integers. The answer is a very large negative number because an overflow "wraps around" from the largest possible integer value to the smallest. There are other numeric types with different limits and precision that you would use when the int type doesn't meet your needs. Let's explore those types of numbers next.

double a3 = 5;
double b3 = 4;
double c3 = 2;
double d3 = (a3 + b3) / c3;
Console.WriteLine(d3);

double a4 = 19;
double b4 = 23;
double c4 = 8;
double d4 = (a4 + b4) / c4;
Console.WriteLine(d4);

//The range of a double value is much greater than integer values. Try the following code in the interactive window
double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

double a5 = 1.0;
double b5 = 3.0;
Console.WriteLine(a5 / b5);

//The M suffix on the numbers is how you indicate that a constant should use the decimal type. Otherwise, the compiler assumes the double type.
decimal a6 = 1.0M;
decimal b6 = 3.0M;
Console.WriteLine(a6 / b6);

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
Console.WriteLine(Math.PI);
