using System;
using System.Collections.Generic;
using System.Linq;
namespace thirdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // object boxedData = 
            List<object> parts = new List<object>();
            parts.Add(7);
            parts.Add(28);
            parts.Add(-1);
            parts.Add(true);
            parts.Add("chair");

            
                int[] values = new int[3];
                int i = 0;
            
             foreach (object obj in parts){
                 Console.WriteLine(obj);
                //  Console.WriteLine(obj.GetType());

                 if (obj.GetType().ToString() == "System.Int32"){
    
                 
                    // values[i] = parts.Select(obj => obj).Distinct();
                    int temp = new int();
                    temp = Convert.ToInt32(obj);
                    values[i] = temp;
                    i += 1;

                                 
                    
                 }
             }
             Console.WriteLine(values.Sum());      

            


        }
    }
}
