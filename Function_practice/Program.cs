using System;
using System.Collections.Generic;
namespace Function_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // printNumbers();
            // PrintOdds();
            // PrintSum();
            int[] arr3 = {1, 5, 10, 7, -2};

            ShiftValues(arr3);

            // int[] temp = {};
            // temp = oddarray();
            // // Console.WriteLine(temp[10]);
            // int temp2 = new int();
            // temp2 = GreaterThanY(arr3, 2);
            // Console.WriteLine(temp2);
            

            // temp = FindMax(arr3);
            // Console.WriteLine(temp);
            
            // GetAverage(arr3);

            // LoopArray(arr3);

            // MinMaxAverage(arr3);
            // EliminateNegatives(arr3);

        }

        public static void printNumbers(){
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
            }
            
        }

        public static void PrintOdds(){
            for(int i = 0; i <= 255; i++){
                if(i % 3 == 0){
                    Console.WriteLine(i);
                }
            }
            
        }
        public static void PrintSum(){
            int sum = new int();
            sum = 0;
            for(int i = 0; i <= 255; i++){
                sum += i;
                Console.WriteLine($"new number: {i}, sum {sum}");
            }
        }
        public static void LoopArray(int[] numbers){
            
            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
        }


        public static int FindMax(int[] numbers){
            int temp = new int();
            temp = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(temp < numbers[i]){
                    temp = numbers[i];
                }
            }
            // Console.WriteLine(temp);

            return temp;
        }

        public static int FindMin(int[] numbers){
            int temp = new int();
            temp = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(temp > numbers[i]){
                    temp = numbers[i];
                }
            }
            // Console.WriteLine(temp);

            return temp;
        }

        public static int GetAverage(int[] numbers){
            int sum = new int();
            sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            int average = new int();
            average = sum / numbers.Length;
            Console.WriteLine("average: " + average);
            return average;
        }
        public static int[] oddarray(){
            List<int> odds = new List<int>();
          
           
            for(int i = 0; i <= 255; i++){
                if(i % 3 == 0){
                  odds.Add(i);
                
                }
            }
            var array = odds.ToArray();
            return array;
        }

        public static int GreaterThanY(int[] numbers, int y){
            List<int> temp = new List<int>();

            for(int i = 0; i < numbers.Length;i++){
                if (numbers[i] > y){
                    Console.WriteLine(numbers[i]);
                    temp.Add(numbers[i]);
                }
            }

            return temp.Count;
        }

        public static void EliminateNegatives(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
                if (numbers[i] < 0){
                    numbers[i] = 0;
                    
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers){
            int min = new int();
            min = FindMin(numbers);
            int max = new int();
            max = FindMax(numbers);
            int average = new int();
            average = GetAverage(numbers);

            Console.WriteLine($"min: {min}, max:{max}, average:{average}");


            // int temp = new int();
            // temp = 0;

            // for(int i = 0; i < numbers.Length; i++){
            //     average += numbers[i];

            // }
            
        }

        public static void ShiftValues(int[] numbers){
            int temp = new int();
            temp = 0;
            
            for(int i = 1; i < numbers.Length; i++){
                if(i != numbers.Length-1){
                    numbers[i-1] = numbers[i];

                }
                else if(i == numbers.Length-1){
                    numbers[i] = 0;
                }

                Console.WriteLine(numbers[i]);
                
            }
        }

    }
}
