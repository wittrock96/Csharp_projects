using System;
using System.Collections.Generic;
namespace hungry_ninja
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Buffet new_buffet = new Buffet();
            Ninja cole = new Ninja();


            


            Food new_food = new_buffet.Serve();

            cole.Eat(new_food);

            new_food = new_buffet.Serve();
            cole.Eat(new_food);
            Console.WriteLine(new_food.Name);
        }
    }
    class Food
    {
        public string Name;
        public int calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string setName, int setCalories, bool setSpicy, bool setSweet)
        {
            this.Name = setName;
            this.calories = setCalories;
            this.IsSpicy = setSpicy;
            this.IsSweet = setSweet;

        }
    }
    class Ninja
    {
        private int calorieIntake;
        public String isFull
        {
            get
            {
                if(calorieIntake >= 1200)
                    return $"ninja is full with {calorieIntake}";
                return "not full";
            }
        }
        public List<Food> FoodHistory;

        public Ninja(){
            this.calorieIntake = 0;

            FoodHistory = new List<Food> {
          
            };
        }
        



        public void Eat(Food Item){

            if(isFull == "not full"){

                calorieIntake += Item.calories;

                FoodHistory.Add(Item);

                Console.WriteLine($"ninja has eaten {Item.Name} with {Item.calories} calories");
                // Food temp = Buffet.Serve();
            }
            else{
                Console.WriteLine("ninja is very full");
            }

        }
    }

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("steak", 732, false, false),
                new Food("burrito", 750, true, false),
                new Food("burger", 600,false, false),
                new Food("sandwich", 350, false, false),
                new Food("cake", 1500, false, true),
                new Food("buffalo chicken sandwhich", 650, true, false),
                new Food("chicken breast", 450, false, false)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            Food selectedFood = Menu[rand.Next(Menu.Count)];

            return selectedFood;
            

        }
    }
}
