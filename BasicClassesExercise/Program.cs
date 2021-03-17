using System;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Mercedes = new Car();

            Mercedes.Year = "2019";
            Mercedes.Make = "C Class";
            Mercedes.Model = "Mercedes";

            Console.WriteLine($"The car is a {Mercedes.Year} {Mercedes.Model} {Mercedes.Make}. ");
        }
    }
}
