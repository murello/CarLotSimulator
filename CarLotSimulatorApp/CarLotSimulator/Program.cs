﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            //Create a seperate class file called Car //done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars



            //Set the properties for each of the cars
            //Call each of the methods for each car

            var michealsCar = new Car();
            michealsCar.Make = "Ford";
            michealsCar.Model = "focus";
            michealsCar.Year = 2013;
            michealsCar.EngineNoise = "vroom";
            michealsCar.HonkNoise = "beep";
            michealsCar.IsDriveable = true;

            lot.Cars.Add(michealsCar);

            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "vruuugh",
                IsDriveable = false

                
            };

             lot.Cars.Add(stevesCar);

            var brettsCar = new Car(2013, "Honda", "Civic", "vroom", "vruuugh", true);
               lot.Cars.Add(brettsCar);

            michealsCar.MakeEngineNoise(michealsCar.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var Car in  lot.Cars)
            {
                Console.WriteLine($"Year: {Car.Year} Make: {Car.Make} Model: {Car.Model}");
            }
        }
    }
}
