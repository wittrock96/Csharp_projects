using System;
using System.Collections.Generic;
namespace secondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // for (int i = 0; i != 255; i++){
            //     Console.WriteLine(i);
            // }
            // for (int i = 0; i != 1000; i++){
            //     if (i % 5 == 0){
            //         Console.WriteLine("buzz");
            //     }
            //     else if (i % 3 == 0){
            //         Console.WriteLine("fizz");
            //     }
            //     if (i %5 == 0 && i % 3 == 0){
            //         Console.WriteLine("fizzbuzz");
            //     }
            // }
            // int i = 0;
            // while (i <= 1000){
            //     if (i % 5 == 0){
            //         Console.WriteLine("buzz");
            //     }
            //     else if (i % 3 == 0){
            //         Console.WriteLine("fizz");
            //     }
            //     if (i %5 == 0 && i % 3 == 0){
            //         Console.WriteLine("fizzbuzz");
            //     }
            //     i += 1;
            // }
            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            foreach (string car in myCars)
            {
    // We no longer need the index, because variable 'car' already represents each indexed value
             Console.WriteLine($"I own a {car}");
            }
            List<string> bikes = new List<string>();
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Insert(1, "kawaski");
            foreach(string bike in bikes){
                Console.WriteLine(bike);
            }


        }
    }
}
