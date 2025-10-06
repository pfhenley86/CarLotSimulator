using System;

namespace CarLotSimulator;

//Create a separate class file called Car

public class Car
{
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    
    //Description
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    //Features
    public string EngineNoise { get; set; }
    public string HonkNoise {get; set;}

    //Check If Driveable
    public bool IsDriveable { get; set; }
    
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {engineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"{Make} {Model} has an honk noise that sounds like {honkNoise}");
    }
    
    //Default Constructor
    public Car()
    {
        CarLot.numberOfCars++;
        //ClassName.StaticMember
    }
    
   //Custom Constructor To Initialize Values
   public Car(string make, string model, int year, bool isDriveable)
   {
       Make = make;
       Model = model;
       Year = year;
       IsDriveable = isDriveable;
       
       CarLot.numberOfCars++;
   }
}