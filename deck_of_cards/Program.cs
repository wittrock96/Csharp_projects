using System;
using System.Collections.Generic;
using System.Linq;
namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck new_deck = new Deck();
            new_deck.shuffle();

            Console.WriteLine(new_deck.cards[51].face);
            Card drawn_card = new_deck.Deal();

            Console.WriteLine($"you have drawn the {drawn_card.face} of {drawn_card.suit}");
            new_deck.reset();
            drawn_card = new_deck.Deal();
            Console.WriteLine($"you have drawn the {drawn_card.face} of {drawn_card.suit}");

            Player cole = new Player("cole");

            Card player_card = cole.draw_card(new_deck);
            cole.draw_card(new_deck);
            cole.draw_card(new_deck);
            cole.draw_card(new_deck);
            cole.draw_card(new_deck);

            cole.discard("king", "diamonds");
            cole.discard(3);


            Console.WriteLine($"{cole.Name} has drawn the {player_card.face} of {player_card.suit}");
            // Card new_card = new Card();

            // Console.WriteLine(new_card.face);
        }
    }

    class Card
    {
        public string face;
        public string suit;
        public int val;

        public Card(string face, string suit, int val){
            this.face = face;
            this.suit = suit;
            this.val = val;

            // Console.WriteLine(this.face + this.suit + this.val
        }
    }

    class Deck
    {

        public List<Card> cards;


        public Deck(){

            cards = new List<Card>();
            new_deck();

        }

        public void new_deck(){
                        string[] suits = {"hearts", "diamonds", "spades", "clubs"};
            string[] faces = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "queen", "king"};
            int val = new int();



            cards = new List<Card>();
            

            for(int i = 0; i < suits.Length; i++){
                for(int x = 0; x < faces.Length; x++){
                    if(faces[x] == "jack" || faces[x] == "queen" || faces[x] == "king"){
                        val = 10;
                    }
                    else if(faces[x] == "Ace"){
                        val = 11;
                    }
                    else{
                        Int32.TryParse(faces[x], out val);
                    }

       
                    cards.Add(new Card(faces[x],suits[i], val));          

                    
                }
            }
        
        }

        public Card Deal(){

            Card remove_card = cards[cards.Count-1];
            cards.Remove(remove_card);

            return remove_card;

        }

        public void shuffle(){
            int shuffling = cards.Count;
            
            Console.WriteLine(cards[51].face);

            Random rand = new Random();
            int i = 0;
            while(i <= 100000){
                int pick_up = rand.Next(0, shuffling);
                
                Card pickUp_card = cards[pick_up];
                cards.Remove(pickUp_card);
                // cards.OrderBy
                int drop_off = rand.Next(shuffling);
                cards.Insert(drop_off, pickUp_card);
                // Console.WriteLine(cards[drop_off].face);

                
                i++;
            }           
            
        } 


        public void reset(){
            new_deck();
        }       

    }



    class Player
    {

        public string Name;
        List<Card> Hand;

        public Player(string name){
            this.Name = name;

            Hand = new List<Card>();
        }

        public Card draw_card(Deck play_deck){
            Card drawn_card = play_deck.Deal();
            addToHand(drawn_card);
            return drawn_card;
        }

        private void addToHand(Card addCard){
            this.Hand.Add(addCard);
        }
        private void removeFromHand(Card removeCard){
            this.Hand.Remove(removeCard);
        }

        public dynamic discard(string face, string suit){
            Card removeCard;
            for(int i = 0; i < Hand.Count; i++){
                if(Hand[i].face == face && Hand[i].suit == suit){
                    removeCard = Hand[i];
                    removeFromHand(Hand[i]);
                    Console.WriteLine("card removed from hand");
                    return removeCard;
                    
                }
            }

            Console.WriteLine("card not found");

            return "NUll";
             

            
            

        }

        public dynamic discard(int index){
            Card removeCard;

                removeCard = Hand[index];
                removeFromHand(removeCard);



            Console.WriteLine("card removed");

            return removeCard;
             

            
            

        }





    }
}
