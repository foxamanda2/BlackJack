using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        // Properties of a Card
        public string Suit { get; set; }
        public string Face { get; set; }

        public List<string> DeckOfCards { get; set;}=new List<string>();
        // public int Value { get; set; }

        // Method for how a card should look
        public string CardBuild()
        {
            return ($"{Face} of {Suit}.");

        }
        public int Value()
        {
            if (Face == "Ace")
            {
                return 11;
            }
            if (Face == "King" || Face == "Queen" || Face == "Jack" || Face == "10")
            {
                return 10;
            }
            if (Face == "2" || Face == "3" || Face == "4" || Face == "5" || Face == "6" || Face == "7" || Face == "8" || Face == "9")
            {
                return int.Parse(Face);
            }
            else
            {
                return 0;
            }
        }
        
        public void CreateDeck()
        {
            var suitList = new List<string>() { "Spades", "Diamonds", "Hearts", "Clubs" };
            var faceList = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };


            foreach (var suit in suitList)
            {
                foreach (var face in faceList)
                {
                 
                    Face = face;
                    Suit = suit;
                    DeckOfCards.Add($"The {Face} of {Suit}");
                    
                }

            }
        }
    

        public void Shuffle()
        {
            var numOfCards = DeckOfCards.Count;
            for (var rightindex = numOfCards - 1; rightindex >= 0; rightindex--)
            {
                var randomNumberGenerator = new Random();
                var leftindex = randomNumberGenerator.Next(rightindex);
                var leftNum = DeckOfCards[leftindex];
                var rightNum = DeckOfCards[rightindex];
             DeckOfCards[rightindex] = leftNum;
             DeckOfCards[leftindex] = rightNum;

            }

        }
         public void PrintAllCards()
        {
            foreach (var cardToPrint in DeckOfCards)
            {
                Console.WriteLine(cardToPrint);
            }
        }


    }
    public class Hand:Card
    {
        public List<Card> HandofCards { get; set; } = new List<Card>();

        public void CardHand(Card cardToPlaceInHand)
        {
            HandofCards.Add(cardToPlaceInHand);
        }

        public int TotalValue()
        {
            var HandTotal = 0;
            foreach (var CardValueToPrint in HandofCards)
            {
                var CurrentCardValue = CardValueToPrint.Value();
                HandTotal = HandTotal + CurrentCardValue;
            }
            return HandTotal;

        }
        public void CardsInHand()
        {
            foreach (var card in HandofCards)
            {
                Console.WriteLine($"The {card.Suit} of {card.Face}");
            }
            var TotalValue=TotalValue();
            Console.WriteLine($"Total value is: {TotalValue}");
        }
    }    
        // public void HitStand(string prompt)
        //  {
        //     //  Prompt for Hit or Stand
        //     Console.Write(prompt);
        //     Console.WriteLine("\n");
        //     var HorS = Console.ReadLine().ToLower();

        //     // Initializing counter for total score
        //     var playertotal = 0;

        //     // If player Decides to Hit program will add card (Only adds one card)
        //     if (HorS == "h" || HorS == "hit")
        //     {
        //     var firstCard = DeckOfCards[0];
        //      DeckOfCards.Remove(firstCard);
        //     HandofCards.Add(firstCard);

        //     //  WriteLine Cards in hand and total points
        //     foreach (var cardToPrint in HandofCards)
        //     {
        //     playertotal = playertotal + cardToPrint.Value;
        //     Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");

        //     }
        //     Console.WriteLine("\n");
        //     Console.Write($"Your Total is: {playertotal}");
        //     Console.WriteLine("\n");

        //         // If Player gets over 21 Automatically bust and close game
        //         if (playertotal > 21)
        //         {
        //             Console.WriteLine("\n");
        //             Console.WriteLine("You busted and lost");
        //             Environment.Exit(-1);
        //         }
        //     }

        //     //  WriteLine cards in list if stand is selected
        //     if (HorS == "s" || HorS == "stand")
        //     {
        //         foreach (var cardToPrint in HandofCards)
        //         {
        //             playertotal = playertotal + cardToPrint.Value;
        //             Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");
        //         }
        //         Console.WriteLine("\n");
        //         Console.Write($"Your total is {playertotal}");
        //     }


        // }
        // public void Houseplay()
        // {
        //     var HouseFinal = 0;

        //     //  Adding Player Final Number
        //     var PlayerFinal = 0;
        //     foreach (var cardToPrint in HandofCards)
        //     {
        //         PlayerFinal = PlayerFinal + cardToPrint.Value;
        //     }

        //     //  Hitting for House
        //     if (HouseFinal < 17)
        //     {
        //         var firstCard = DeckOfCards[0];
        //      DeckOfCards.Remove(firstCard);
        //         HouseHand.Add(firstCard);
        //     }

        //     //  Finding House total and Cards
        //     foreach (var cardToPrint in HouseHand)
        //     {
        //         HouseFinal = HouseFinal + cardToPrint.Value;
        //         Console.WriteLine($"House hand is:{cardToPrint.CardBuild()}");
        //     }
        //     Console.WriteLine("\n");
        //     Console.WriteLine($"Final House Total:{HouseFinal}");


        //     //  Comparing House total to Player Total
        //     if (HouseFinal > 21 && PlayerFinal == 21)
        //     {
        //         Console.WriteLine("\n");
        //         Console.WriteLine("You Won.");
        //         Console.WriteLine("\n");
        //     }
        //     if (HouseFinal > 21)
        //     {
        //         Console.WriteLine("\n");
        //         Console.WriteLine("House Busted. You Won.");
        //         Console.WriteLine("\n");
        //         Environment.Exit(-1);
        //     }

        //     if (HouseFinal > PlayerFinal)
        //     {
        //         Console.WriteLine("\n");
        //         Console.WriteLine("House won. I am sorry you lost");
        //         Console.WriteLine("\n");
        //     }
        //     if (HouseFinal < PlayerFinal)
        //     {
        //         Console.WriteLine("\n");
        //         Console.WriteLine("YOU WON!");
        //         Console.WriteLine("\n");
        //     }

        //     if (HouseFinal == PlayerFinal)
        //     {
        //         Console.WriteLine("\n");
        //         Console.WriteLine("House won. I am sorry you lost");
        //         Console.WriteLine("\n");
        //     }


    public class Program
    {
        // static void Displaygame()
        // {
        //     Console.WriteLine();
        //     Console.WriteLine("Welcome to BlackJack: A Game of Chances and Struggle");
        //     Console.WriteLine();
        // }

        //  //  Prompt for playing game
        // static void BeginPrompt(string prompt)
        // {
        //     Console.Write(prompt);
        //     var openingQuestion = Console.ReadLine().ToLower();
        //     if (openingQuestion == "yes" || openingQuestion == "y")
        //     {
        //         Console.WriteLine("Let the game begin");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Okay no game today.");
        //         Environment.Exit(-1);
        //     }
        // }
        static void Main(string[] args)
        {
                // Opening Prompts
                Displaygame();
                BeginPrompt("Are you ready to play? Yes or No? ");


                // New Game
                // var game1 = new Card();
                // game1.CreateDeck();
                // game1.Shuffle();
                // game1.CardsInHand(); 

                var firstPlayerCard = deck[0];
                DeckOfCards.Remove(firstPlayerCard); 

                
                var playerHand = new Hand();
                playerHand.CreateDeck();
                playerHand.Shuffle();
                playerHand.CardsInHand(); 
                playerHand.CardsInHand(firstPlayerCard); 

        }
    }}
        