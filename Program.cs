using System;

namespace interface_assignment
{
    // lab question - Create a C# program that implements an IVehicle interface with two methods, 
    // one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. 
    // Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the car.
    // The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0.
    //  The Refuel method will increase the gasoline of the car and return true.
    // To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, 
    // finally execute the Drive method of the car.

    interface Ivehicle
    {
        void Drive();
        bool Refuel (int AmountRefuel);
        
    }
    class Car: Ivehicle
    {
        public int startingGas{get; set;}
        public Car(int StartingGas)
        {
            startingGas = StartingGas;
        }

        public void Drive()
        {
            if (startingGas > 0)
            {
                Console.WriteLine("The car is driving");
            }
        }
        public bool Refuel(int AmountRefuel)
        {
            startingGas += AmountRefuel;  
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car(0);
            Console.WriteLine("how much fuel do you want to add");
            int Refuel = int.Parse(Console.ReadLine());
            newCar.Refuel(Refuel);
            newCar.Drive();
        }
    }
}
