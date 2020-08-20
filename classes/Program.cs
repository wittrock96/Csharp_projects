using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human Cole = new Human("cole");

            Human Hunter = new Human("hunter");

            Cole.attack(Hunter);



        }
    }

    class Human
    {
        public String Name;
        public int strength;        
        public int intelligence;
        public int dexterity;
        private int health;

        public Human(string val){
            Name = val;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;

        }

        public Human(string name, int setStrength, int setIntelligence, int setDexterity, int setHealth)
        {
            Name = name;
            strength = setStrength;
            intelligence = setIntelligence;
            dexterity = setDexterity;
            health = setHealth;

        }

        public int attack(Human Target){
            Console.WriteLine($"{this.Name} attacks {Target.Name}");
            Console.WriteLine(Target.health);

            int damage = 5 * this.strength;
            Target.health -= damage;

            Console.WriteLine(Target.health);

            return Target.health;

        }



    }
}
