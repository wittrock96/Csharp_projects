using System;
using System.Collections.Generic;
namespace iron_ninja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        public Drink(string id, int cal, bool spic, bool swt){

            this.Name = id;
            this.Calories = cal;
            this.IsSpicy = spic;
            this.IsSweet = swt;

        }

        public string GetInfo(){
            return $"{Name} (drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        
        // Implement a GetInfo Method
        // Add a constructor method
    }   

}