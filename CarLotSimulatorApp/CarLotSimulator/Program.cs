using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE -- Create a seperate class file called Car
            //DONE -- Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE -- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE -- The methods should take one string parameter: the respective noise property

            var NewCarLot = new CarLot();

            //DONE -- Now that the Car class is created we can instanciate 3 new cars

            var Car1 = new Car();
            NewCarLot.CarList.Add(Car1);

            var Car2 = new Car() { Year = 1993, Make = "Dodge", Model = "Dodger", EngineNoise = "Vrum", HonkNoise = "Beep" };
            NewCarLot.CarList.Add(Car2);

            var Car3 = new Car() 
            { 
                Year = 2025, 
                Make = "Tesla", 
                Model = "CyberHurst", 
                EngineNoise = "...", 
                HonkNoise = "Musk" 
            };
            NewCarLot.CarList.Add(Car3);

            //DONE -- Set the properties for each of the cars
            Car1.Year = 1982;
            Car1.Make = "Honda";
            Car1.Model = "Accord";
            Car1.EngineNoise = "Vroom";
            Car1.HonkNoise = "Honk";
            Car1.isDrivable = false;
            //DONE -- Call each of the methods for each car
            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHonkNoise(Car1.HonkNoise);

            Car2.MakeEngineNoise(Car2.EngineNoise);
            Car2.MakeHonkNoise(Car2.HonkNoise);

            Car3.MakeEngineNoise(Car3.EngineNoise);
            Car3.MakeHonkNoise(Car3.HonkNoise);
            //*************BONUS*************//

            //DONE -- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE -- Create a CarLot class
            //DONE -- It should have at least one property: a List of cars
            //DONE -- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE -- At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (Car car in NewCarLot.CarList)
            {
                Console.WriteLine($"Details: {car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
