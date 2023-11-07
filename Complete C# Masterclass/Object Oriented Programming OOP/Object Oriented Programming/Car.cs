using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming;

public class Car {
    private string name;
    public Car() {
        Console.WriteLine("\nCar instantiation successfull.");
    }

    public Car(string name) {
        this.name = name;
        Console.WriteLine("\n" + this.name + " instantiation successfull.");
    }

    public void Drive() {
        Console.WriteLine("\n" + this.name + " is driving...");
    }

    public void Stop() {
        Console.WriteLine("\n" + this.name + " is stopped...");
    }
}