using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            
            //Create a CarLot class
            var carLotOne = new CarLot();
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            //Check number of cars before creationg
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            
            //Car One
            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Mustang";
            carOne.Year = 2005;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vroom Vroom");
            carOne.MakeHonkNoise("Honk Honk");
            
            // Add carOne to ParkingLot
            carLotOne.ParkingLot.Add(carOne);
            
            //Check number of cars created
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            
            
            //Car Two
            var carTwo = new Car()
            {
                Make = "Nissan", 
                Model = "Xterra", 
                Year = 2012, 
                IsDriveable = false
            };
            
            carTwo.MakeEngineNoise("Putt Putt");
            carTwo.MakeHonkNoise("Squeak, Squeak");
            
            // Add carTwo to ParkingLot
            carLotOne.ParkingLot.Add(carTwo);
            
            //Check number of cars created
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            
            //Car Three
            var carThree = new Car("Hyundai", "Palisade", 2024, true);
            
            carThree.MakeEngineNoise("Wow Wow");
            carThree.MakeHonkNoise("Boop, Boop");
            
            // Add carTwo to ParkingLot
            carLotOne.ParkingLot.Add(carThree);
            
            //Check number of cars created
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            //*************BONUS X 2*************//

            
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLotOne.CheckCars();
            
        }
    }
}
