using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Card
    {
        // Properties of a Card
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }

        // Method for how a card should look
        public string CardBuild()
        {
            return ($"{Face} of {Suit}.");

        }

    }

    class Deck
    {
        // List properties for Deck (Deck now is where Card is stored)
        public List<Card> CardsInDeck { get; set; } = new List<Card>();
        public List<Card> PlayerHand { get; set; } = new List<Card>();
        public List<Card> HouseHand { get; set; } = new List<Card>();

        //  Method to add a Deck to a list in class Cards
        public void CreateDeck()
        {
            var suitList = new List<string>() { "Spades", "Diamonds", "Hearts", "Clubs" };
            var faceList = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };


            foreach (var suit in suitList)
            {
                foreach (var face in faceList)
                {

                    var newCard = new Card();
                    newCard.Suit = suit;
                    newCard.Face = face;

                    int value = 0;
                    if (face == "Ace")
                    {
                        value = 11;
                    }
                    if (face == "King" || face == "Queen" || face == "Jack" || face == "10")
                    {
                        value = 10;
                    }
                    if (face == "2")
                    {
                        value = 2;
                    }
                    if (face == "3")
                    {
                        value = 3;
                    }
                    if (face == "4")
                    {
                        value = 4;
                    }
                    if (face == "5")
                    {
                        value = 5;
                    }
                    if (face == "6")
                    {
                        value = 6;
                    }
                    if (face == "7")
                    {
                        value = 7;
                    }
                    if (face == "8")
                    {
                        value = 8;
                    }
                    if (face == "9")
                    {
                        value = 9;
                    }

                    newCard.Value = value;

                    CardsInDeck.Add(newCard);
                }

            }

        }

        //  Method to shuffle Cards
        public void Shuffle()
        {
            var numOfCards = CardsInDeck.Count;
            for (var rightindex = numOfCards - 1; rightindex >= 0; rightindex--)
            {
                var randomNumberGenerator = new Random();
                var leftindex = randomNumberGenerator.Next(rightindex);
                var leftNum = CardsInDeck[leftindex];
                var rightNum = CardsInDeck[rightindex];
                CardsInDeck[rightindex] = leftNum;
                CardsInDeck[leftindex] = rightNum;

            }

        }

        //  Method to print all of the cards
        public void PrintCards()
        {
            foreach (var cardToPrint in CardsInDeck)
            {
                Console.WriteLine(cardToPrint.CardBuild());
            }
        }

        //  Method incase extra player cards are added to the instances
        public void PlayerCard()
        {
            var firstCard = CardsInDeck[0];
            CardsInDeck.Remove(firstCard);
            PlayerHand.Add(firstCard);

        }

        // Method incase extra house cards are added to the instances
        public void HouseCard()
        {
            var firstCard = CardsInDeck[0];
            CardsInDeck.Remove(firstCard);
            HouseHand.Add(firstCard);

        }

        //  Method to print Player cards
        public void PrintPlayerCards()
        {
            var playertotal = 0;
            foreach (var cardToPrint in PlayerHand)
            {
                playertotal = playertotal + cardToPrint.Value;
                Console.WriteLine(cardToPrint.CardBuild());

            }
            Console.WriteLine($"Your total is {playertotal}");
        }

        //  Method to print House cards
        public void PrintHouseCards()
        {
            var Housetotal = 0;
            foreach (var cardToPrint in HouseHand)
            {
                Housetotal = Housetotal + cardToPrint.Value;
                Console.WriteLine(cardToPrint.CardBuild());
            }
        }



        // Prompt for Overall Game
        static void Displaygame()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to BlackJack: A Game of Chances and Struggle");
            Console.WriteLine();
        }

        //  Prompt for playing game
        static void BeginPrompt(string prompt)
        {
            Console.Write(prompt);
            var openingQuestion = Console.ReadLine().ToLower();
            if (openingQuestion == "yes" || openingQuestion == "y")
            {
                Console.WriteLine("Let the game begin");
            }
            else
            {
                Console.WriteLine("Okay no game today.");
                Environment.Exit(-1);
            }
        }

        public void HitStand(string prompt)
        {
            //  Prompt for Hit or Stand
            Console.Write(prompt);
            Console.WriteLine("\n");
            var HorS = Console.ReadLine().ToLower();

            // Initializing counter for total score
            var playertotal = 0;

            // If player Decides to Hit program will add card (Only adds one card)
            if (HorS == "h" || HorS == "hit")
            {
                var firstCard = CardsInDeck[0];
                CardsInDeck.Remove(firstCard);
                PlayerHand.Add(firstCard);

                //  WriteLine Cards in hand and total points
                foreach (var cardToPrint in PlayerHand)
                {
                    playertotal = playertotal + cardToPrint.Value;
                    Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");
                }
                Console.WriteLine("\n");
                Console.Write($"Your Total is: {playertotal}");
                Console.WriteLine("\n");

                // If Player gets over 21 Automatically bust and close game
                if (playertotal > 21)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You Lost");
                    Environment.Exit(-1);
                }
            }

            //  WriteLine cards in list if stand is selected
            if (HorS == "s" || HorS == "stand")
            {
                foreach (var cardToPrint in PlayerHand)
                {
                    playertotal = playertotal + cardToPrint.Value;
                    Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");
                }
                Console.WriteLine("\n");
                Console.Write($"Your total is {playertotal}");
            }


        }
        public void Houseplay()
        {
            var HouseFinal = 0;

            //  Adding Player Final Number
            var PlayerFinal = 0;
            foreach (var cardToPrint in PlayerHand)
            {
                PlayerFinal = PlayerFinal + cardToPrint.Value;
            }

            //  Hitting for House
            if (HouseFinal < 17)
            {
                var firstCard = CardsInDeck[0];
                CardsInDeck.Remove(firstCard);
                HouseHand.Add(firstCard);
            }

            //  Finding House total and Cards
            foreach (var cardToPrint in HouseHand)
            {
                HouseFinal = HouseFinal + cardToPrint.Value;
                Console.WriteLine($"House hand is:{cardToPrint.CardBuild()}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Final House Total:{HouseFinal}");


            //  Comparing House total to Player Total
            if (HouseFinal > 21 && PlayerFinal == 21)
            {
                Console.WriteLine("\n");
                Console.WriteLine("You Won.");
                Console.WriteLine("\n");
            }
            if (HouseFinal > 21)
            {
                Console.WriteLine("\n");
                Console.WriteLine("House Busted. You Won.");
                Console.WriteLine("\n");
                Environment.Exit(-1);
            }

            if (HouseFinal > PlayerFinal)
            {
                Console.WriteLine("\n");
                Console.WriteLine("House won. I am sorry you lost");
                Console.WriteLine("\n");
            }
            if (HouseFinal < PlayerFinal)
            {
                Console.WriteLine("\n");
                Console.WriteLine("YOU WON!");
                Console.WriteLine("\n");
            }

            if (HouseFinal == PlayerFinal)
            {
                Console.WriteLine("\n");
                Console.WriteLine("House won. I am sorry you lost");
                Console.WriteLine("\n");
            }



        }


        static void Main(string[] args)
        {
            // Opening Prompts
            Displaygame();
            BeginPrompt("Are you ready to play? Yes or No? ");


            // New Game
            var game1 = new Deck();
            game1.CreateDeck();
            game1.Shuffle();
            game1.PlayerCard();
            game1.PlayerCard();
            game1.PrintPlayerCards();
            Console.WriteLine("------------");
            game1.HitStand("Do you want to hit or stand?");
            Console.WriteLine("\n");
            game1.HouseCard();
            game1.HouseCard();
            game1.Houseplay();

        }
    }
}






