using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }


        public string CardBuild()
        {
            return ($"{Face} of {Suit}");

        }

        public int Value()
        {
            // Absolutely could be a switch!
            if (Face == "Ace")
            {
                return 11;
            }
            if (Face == "King" || Face == "Queen" || Face == "Jack" || Face == "10")
            {
                return 10;
            }
            if (Face == "2")
            {
                return 2;
            }
            if (Face == "3")
            {
                return 3;
            }
            if (Face == "4")
            {
                return 4;
            }
            if (Face == "5")
            {
                return 5;
            }
            if (Face == "6")
            {
                return 6;
            }
            if (Face == "7")
            {
                return 7;
            }
            if (Face == "8")
            {
                return 8;
            }
            if (Face == "9")
            {
                return 9;
            }

        }

    }

    class Deck
    {
        public List<Card> CardsInDeck { get; set; } = new List<Card>();
        public List<Card> PlayerHand { get; set; } = new List<Card>();
        public List<Card> HouseHand { get; set; } = new List<Card>();

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

                    CardsInDeck.Add(newCard);
                }

            }

        }

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

        public void PrintCards()
        {
            foreach (var cardToPrint in CardsInDeck)
            {
                Console.WriteLine(cardToPrint.CardBuild());
            }
        }

        public void PlayerCard()
        {
            var firstCard = CardsInDeck[0];
            CardsInDeck.Remove(firstCard);
            PlayerHand.Add(firstCard);

        }

        public void HouseCard()
        {
            var firstCard = CardsInDeck[0];
            CardsInDeck.Remove(firstCard);
            HouseHand.Add(firstCard);

        }

        public void PrintPlayerCards()
        {
            foreach (var cardToPrint in PlayerHand)
            {
                Console.WriteLine($"Your cards are: {cardToPrint.CardBuild()}");
            }
        }
        public void PrintHouseCards()
        {
            foreach (var cardToPrint in HouseHand)
            {
                Console.WriteLine($"House cards are: {cardToPrint.CardBuild()}");
            }
        }

        static void Displaygame()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to BlackJack: A Game of Chances and Struggle");
            Console.WriteLine();
        }

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
        class Player
        {

        }

        static void Main(string[] args)
        {
            Displaygame();
            BeginPrompt("Are you ready to play? Yes or No?");

            var player1 = new Deck();
            player1.CreateDeck();
            player1.Shuffle();
            player1.PlayerCard();
            player1.PlayerCard();
            player1.PrintPlayerCards();
            Console.WriteLine("------------");
            player1.HouseCard();
            player1.HouseCard();
            player1.PrintHouseCards();





        }
    }
}






