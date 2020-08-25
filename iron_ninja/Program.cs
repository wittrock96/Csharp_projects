using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Buffet buffet1 = new Buffet();

            SpiceHound spice1 = new SpiceHound();

            SweetTooth sweet1 = new SweetTooth();

            spice1.Consume(buffet1.menu[2]);
            sweet1.Consume(buffet1.menu[0]);
            
            spice1.Consume(buffet1.menu[2]);
            sweet1.Consume(buffet1.menu[0]);

        }
    }

    class Buffet
    {
        public List<IConsumable> menu;

        public Buffet(){
            menu = new List<IConsumable>()
            {
                new Drink("Lagunitas", 1500, false, false),
                new Drink("angry orchard", 1500, false, true),
                new Drink("Coke", 120, false, false)
            };
        }
        
    }
}
