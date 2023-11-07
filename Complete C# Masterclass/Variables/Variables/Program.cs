/*
    Sami Munir
    Rutgers University
    smunir2001@gmail.com
    October 24, 2023
*/

Console.WriteLine("Variables");
int num = 7; // -2,147,483,648 to 2,147,483,647
Console.WriteLine("num: " + num);
float pi = 3.1415F;
Console.WriteLine("pi: " + pi);
bool isRunning = true;
Console.WriteLine("isRunning: " + isRunning);
string myName = "Sami";
Console.WriteLine("myName: " + myName);
char symbol = '$';
Console.WriteLine("symbol: " + symbol);

Console.WriteLine("\nSome more data types...");
sbyte signedByte = 120; // -128 to 127
Console.WriteLine("signedByte: " + signedByte);
short shortNum = 30000; // -32767 to 32767
Console.WriteLine("shortNum: " + shortNum);
long longNum = 9000000000000000;
Console.WriteLine("longNum: " + longNum);
double doubleNum = 1.5;
Console.WriteLine("doubleNum: " + doubleNum);
decimal decimalNum = 1.5m;
Console.WriteLine("decimalNum: " + decimalNum);

int num1 = 13;
int num2 = 23;
int sum = num1 + num2;
Console.WriteLine("sum: " + sum);

string name = "Sambreezy";
Console.WriteLine("\nname: " + name);
string greeting = "Hello";
Console.WriteLine("\t" + greeting + ", " + name);
name = name.ToUpper();
Console.WriteLine("name: " + name);

for (int i = 0; i < 5; i++) {
    Console.Write((i + 1) + ", ");
}
Console.WriteLine();

string input = Console.ReadLine();
Console.WriteLine("input: " + input);
Console.Read();

double myDouble = 13.37;
int myInt = (int) myDouble;
Console.WriteLine("\nmyDouble: " + myDouble);
Console.WriteLine("myInt: " + myInt);

string stringForFloat = "0.85";
string stringForInt = "12345";
int intString = Int32.Parse(stringForInt);
float f = float.Parse(stringForFloat);
System.Console.WriteLine("\nint = {0} | float = {1}", intString, f);

public class Test {
    private void hello() {
        Console.WriteLine("Hello, World!");
    }
}