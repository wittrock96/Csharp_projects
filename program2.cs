using System;
using System.Collections.Generic;
using System.Linq;
namespace dictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             

            // Dictionary<string, string> profile = new Dictionary<string, string>();
            
            // profile.Add("name", "speros");
            // profile.Add("language", "PHP");
            // profile.Add("Location", "Greece");
            // Console.WriteLine("instructor profile");
            // Console.WriteLine("name - " + profile["name"]);
            // Console.WriteLine("Language - " + profile["language"]);
            // Console.WriteLine("Location - " + profile["Location"]);
            
            // foreach (KeyValuePair<string, string> entry in profile){
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            // foreach(var entry in profile){
            //     Console.WriteLine(entry.Key + " is " + entry.Value);
            // }
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] wordArry = {"Tim", "Martin", "Nikki", "Sara"};
            Boolean[] Array = {true, false, true, false, true, false, true, false, true, false, true};

            List<string> iceCream = new List<string>();

            iceCream.Add("cookie dough");
            iceCream.Add("vanilla");
            iceCream.Add("chocolate");
            iceCream.Add("coookies and cream");
            iceCream.Add("chocolate chip");

            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[3]);
            // iceCream.RemoveAt(3);
            // Console.WriteLine(iceCream.Count);
            // Console.WriteLine(iceCream[3]);

            Dictionary<string, string> people = new Dictionary<string, string>();

            for (var i = 0; i != wordArry.Length; i++){
                Random rand = new Random();
                people.Add(wordArry[i], iceCream[rand.Next(0, 4)]);
                Console.WriteLine($"{people.ElementAt(i).Key} + {people.ElementAt(i).Value}");

            }
        }
    }
}
