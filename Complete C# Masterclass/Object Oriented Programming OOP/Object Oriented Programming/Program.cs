/*
    Sami Munir
    Rutgers University
    smunir2001@gmail.com
    October 24, 2023
*/
using Object_Oriented_Programming;

class Program {
    static void Main(string[] args) {
        string name = "BMW";
        Car bmw = new Car(name);
        bmw.Drive();
        Console.WriteLine("\nEnter 1 to stop the car...");
        string input = Console.ReadLine();
        if (input == "1") {
            bmw.Stop();
        } else {
            Console.WriteLine("\n" + name + " is driving endlessly...");
        }
    }
}