using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }

        public string CardBuild()
        {
            return ($"{Face} of {Suit}.");

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
            var playertotal = 0;
            foreach (var cardToPrint in PlayerHand)
            {
                playertotal = playertotal + cardToPrint.Value;
                Console.WriteLine(cardToPrint.CardBuild());

            }
            Console.WriteLine($"Your total is {playertotal}");
        }




        public void PrintHouseCards()
        {
            var Housetotal = 0;
            foreach (var cardToPrint in HouseHand)
            {
                Housetotal = Housetotal + cardToPrint.Value;
                Console.WriteLine(cardToPrint.CardBuild());
            }
            // Console.WriteLine($"Your total is {Housetotal}");
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

        public void HitStand(string prompt)
        {
            Console.Write(prompt);
            var HorS = Console.ReadLine().ToLower();
            var playertotal = 0;

            // while (playertotal)
            // {

            if (HorS == "h" || HorS == "hit")
            {
                var firstCard = CardsInDeck[0];
                CardsInDeck.Remove(firstCard);
                PlayerHand.Add(firstCard);


                foreach (var cardToPrint in PlayerHand)
                {
                    playertotal = playertotal + cardToPrint.Value;
                    Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");
                }
                Console.WriteLine("\n");
                Console.Write(playertotal);
                Console.WriteLine("\n");


                if (playertotal > 21)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You Lost");
                    Environment.Exit(-1);
                }
            }

            if (HorS == "s" || HorS == "stand")
            {
                foreach (var cardToPrint in PlayerHand)
                {
                    playertotal = playertotal + cardToPrint.Value;
                    Console.WriteLine($"Your hand is: {cardToPrint.CardBuild()}");
                }
                Console.Write($"Your total is {playertotal}");
            }


        }
        public void Houseplay()
        {
            var HouseFinal = 0;

            var PlayerFinal = 0;
            foreach (var cardToPrint in PlayerHand)
            {
                PlayerFinal = PlayerFinal + cardToPrint.Value;
            }

            // while (HouseFinal < 17)
            // {
            foreach (var cardToPrint in HouseHand)
            {
                HouseFinal = HouseFinal + cardToPrint.Value;
                Console.WriteLine($"House hand is:{cardToPrint.CardBuild()}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Final House Total:{HouseFinal}");


            // var firstCard = CardsInDeck[0];
            // CardsInDeck.Remove(firstCard);
            // HouseHand.Add(firstCard);

            // if (Housetotal == 17)
            // {
            //     var finalTotal = Housetotal;
            //     Console.WriteLine(Housetotal);
            // }

            // }
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
            Displaygame();
            BeginPrompt("Are you ready to play? Yes or No?");

            // Create deck player deck and cards in main

            var player1 = new Deck();
            player1.CreateDeck();
            player1.Shuffle();
            player1.PlayerCard();
            player1.PlayerCard();
            player1.PrintPlayerCards();
            // player1.PrintPlayerCards();
            Console.WriteLine("------------");
            player1.HitStand("Do you want to hit or stand?");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            player1.HouseCard();
            player1.HouseCard();

            // Console.WriteLine("------------");
            // player1.HitStand("Do you want to hit or stand?");
            player1.Houseplay();

        }
    }
}
// Class properties or method 





