using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a


            CarLot lot = new CarLot();
            

            Car Car1 = new Car();
            Car1.Year = 2016;
            Car1.Make = "Chevy";
            Car1.Model = "Camaro";
            Car1.EngineNoise = "VROOM";
            Car1.HonkNoise = "BEEP";
            Car1.IsDriveable = true;
            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHonkNoise(Car1.HonkNoise);
            lot.CarLots.Add(Car1);

            Car Car2 = new Car() { Year = 2020, Make = "Tesla", Model = "X", EngineNoise = "ROAR", HonkNoise = "BOOP", IsDriveable = true };
            Car2.MakeEngineNoise(Car2.EngineNoise);
            Car2.MakeHonkNoise(Car2.HonkNoise);
            lot.CarLots.Add(Car2);

            Car Car3 = new Car(2010, "Subaru", "Forester", "ROOM", "HONK",false);
            Car3.MakeEngineNoise(Car3.EngineNoise);
            Car3.MakeHonkNoise(Car3.HonkNoise);
            lot.CarLots.Add(Car3);

            Console.WriteLine($"number of cars created: {CarLot.numberOfCars}");
            foreach (var car in lot.CarLots)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");                
            }   
        } 
    }
}
