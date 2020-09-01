using System;

using System.ComponentModel.DataAnnotations;

namespace DojoDachi.Models
{
    public class Dachi
    {
        public int happiness {get; set;}
        public int fullness {get; set;}
        public int meals {get; set;}
        public int energy {get; set; }

        public Dachi(){
            happiness = 20;
            fullness = 20;
            energy = 50;
            meals = 3;

        }
        public Dachi feed(){
            Random rand = new Random();
            int fed = rand.Next(5,10);

            this.meals -= 1;
            this.fullness += fed;

            return this;
        }

        public void play(){
            Random rand = new Random();
            int joy = rand.Next(1,100);
            int happy = rand.Next(5,10);
            if(joy <= 25){
                meals -= 1;
                energy -=5;
            }
            else{
                meals -= 1;
                energy -=5;
                happiness += happy;

            }
        }
    }
}