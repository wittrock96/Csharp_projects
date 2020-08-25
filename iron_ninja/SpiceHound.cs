using System;
using System.Collections.Generic;
namespace iron_ninja
{

    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if(calorieIntake >= 1200)
                    return true;
                return false;
            }
        }
        public override void Consume(IConsumable Item)
        {

            if(IsFull == false){

                calorieIntake += Item.Calories;

                ConsumptionHistory.Add(Item);

                Console.WriteLine($"ninja has eaten {Item.Name} with {Item.Calories} calories");
                // Food temp = Buffet.Serve();
            }
            else{
                Console.WriteLine("ninja is very full");
            }

        }
            // provide override for Consume
        }
}

