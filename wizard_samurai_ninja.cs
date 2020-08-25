using System;

namespace dnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Wizard cole = new Wizard("cole");
            Wizard cole2 = new Wizard("cole2");

            Ninja thisNinja = new Ninja("ninja1");
            Ninja otherNinja = new Ninja("Ninja2");

            Samurai thisSam = new Samurai("sam1");
            Samurai otherSam = new Samurai("sam2");

            // otherSam.Health = 300;


            
      
            int dmg = cole.Attack(thisSam);
            int hp = cole2.Heal(thisSam);

            // string restore = thisSam.meditate();

            Console.WriteLine(thisSam.meditate());


            
            Console.WriteLine($"{cole.Name} dealt {dmg} damage to {thisSam.Name}");
            Console.WriteLine($"{cole2.Name} healed {thisSam.Name} for {hp}");

        }


    }

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
         
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp)
        {
            
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return dmg;
        }
    }

    class Wizard : Human
    {
        // int magic;

        public Wizard(string name) : base(name)
        {
            // Console.WriteLine(base.Health);
            base.Health = 50;
            base.Intelligence = 25;

        }

        public override int Attack(Human target)
        { 
            Console.WriteLine(target.Health);
            int dmg = base.Intelligence * 5;
            target.Health  -= dmg;
            base.Health += dmg;
            Console.WriteLine(base.Health);
            Console.WriteLine(target.Health);

            return dmg;
        }

        public int Heal(Human target){
            Console.WriteLine("healing");
            int hp = 10 * base.Intelligence;

            target.Health += hp;

            return hp;

        }


    }
    class Ninja : Human
    {

        public Ninja(string name) : base(name)
        {
            base.Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int chance = rand.Next(1,100);
            int dmg = 5 * base.Dexterity;
            if(chance <= 20){
                dmg += 10;
            }
            
            target.Health -= dmg;

            return dmg;
        }

        public int Steal(Human target){
            int dmg = 5;
            target.Health -= 5;
            base.Health += dmg;


            return dmg;


        }
        

    }


    class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            base.Health = 200;
        }

        public override int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if(target.Health < 50){
                target.Health = 0;
            }
            else{
                target.Health -= dmg;
            }
       

            return dmg;
        }

        public string meditate(){

            base.Health = 200;

            return $"${base.Name} has restored health";
        }
    }

}
