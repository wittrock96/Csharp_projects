using System;
using System.Collections.Generic;
namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Names());
            // RandomArray();

            // string temp = TossCoin();
            // Console.WriteLine(temp);
            
        }

        public static int[] RandomArray(){
            Random rand = new Random();

            int[] randArray = new int[20];

            for(int i = 0; i < randArray.Length; i++){
                randArray[i] = rand.Next(5,25);
                
            }

            return randArray;

        }

        public static String TossCoin(){
            Console.WriteLine("tossing a coin");           

            Random rand = new Random();

            int temp = rand.Next(1,100);

            if(temp < 50){
                return "Heads!";
            }
            else{
                return "Tails";
            }           

        }

        public static List<string> Names(){
            Random rand = new Random();
            List<string> nameList = new List<string>();
            List<string> newList = new List<string>();
            
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");

            int count = nameList.Count;
            int last = count-1;

            for(int i = 0; i < last; i ++){
                int r = rand.Next(i, count);
                var tmp = nameList[i];
                nameList[i] = nameList[r];
                nameList[r] = tmp;
                Console.WriteLine(nameList[i]);
                if (nameList[i].Length > 5){
                    newList.Add(nameList[i]);
                }
            }

            return newList;



        }
    }
}
