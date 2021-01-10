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
        public int ValueofCards()
        {
            switch (Face)
            {
                case "Ace":
                    return 11;
                case "King":
                case "Queen":
                case "Jack":
                case "10":
                    return 10;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
            }
        }

        class Deck
        {
            public List<Card> CardsInDeck { get; set; } = new List<Card>();
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





        }

        var playerhand = new List<string>() { deckOfCards[0], deckOfCards[1] };

        // var househand = new List<string>() { deckOfCards[2], deckOfCards[3] };

        // Removing cards from deck
        //     for (var removedCard = 0; removedCard < 4; removedCard++)
        //     {
        //         deckOfCards.Remove(deckOfCards[0]);
        //     }




        // }
        // public List<Card> cards;

        // class Draw()
        //         {
        //     //  Creating new lists for hands 
        //     var playerhand = new List<string>() { deckOfCards[0], deckOfCards[1] };

        //     var househand = new List<string>() { deckOfCards[2], deckOfCards[3] };

        //     // Removing cards from deck
        //     for (var removedCard = 0; removedCard < 4; removedCard++)
        //     {
        //         deckOfCards.Remove(deckOfCards[0]);
        //     }
        // }
        class Program
        {
            static void Displaygame()
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to BlackJack: A Game of Chances and Struggle");
                Console.WriteLine();
            }
            static void BeginPrompt(string prompt)
            {
                Console.Write(prompt);
                var beginques = Console.ReadLine().ToLower();
                if (beginques == "yes")
                {
                    foreach (var card in playerhand)
                    {
                        Console.WriteLine($"Your hand is {card}");
                    }
                }
                else
                {
                    Console.WriteLine("Okay no game today.");
                    Environment.Exit(-1);
                }
            }

            static void Main(string[] args)
            {

                //  Trying to hit or Stand
                Console.Write("Would you like to Hit or Stand? Type H for hit or S for stand:");
                var hors = Console.ReadLine().ToLower();

                if (hors == "h")
                {
                    playerhand.Add(deckOfCards[0]);
                    foreach (var card in playerhand)
                    {
                        Console.WriteLine($"Your hand is: {card}");
                    }
                    for (var removedCard = 0; removedCard < 1; removedCard++)
                    {
                        deckOfCards.Remove(deckOfCards[0]);
                    }

                }
                if (hors == "s")
                {
                    foreach (var card in playerhand)
                    {
                        Console.WriteLine($"You are going to stand with: {card}");
                    }

                }
                foreach (var change in values)
                {
                    Console.WriteLine(change);
                }

                List<int> intList = stringList.ConvertAll(int.Parse)



         Printing out new removed deck
                foreach (var cards in deckOfCards)
                {
                    Console.WriteLine(cards);

                }

                // Trying to add a hand to my list
                playerhand.Add(deckOfCards[0]);
                playerhand.Add(deckOfCards[1]);

                for (var hand = 0; hand < playerhand.Count; hand++)
                {
                    Console.WriteLine($"players hand {playerhand[hand]}");

                }




            }






// var valueDeck = deckOfCards;

// var values = new List<int>();

// foreach (var face in valueDeck)
// {
//     switch (face[0])
//     {
//         case 'A':
//             values.Add(11);
//             break;
//         case 'K':
//         case 'Q':
//         case 'J':
//             values.Add(10);
//             break;
//         case '2':
//             values.Add(2);
//             break;
//         case '3':
//             values.Add(3);
//             break;
//         case '4':
//             values.Add(4);
//             break;
//         case '5':
//             values.Add(3);
//             break;
//         case '6':
//             values.Add(6);
//             break;
//         case '7':
//             values.Add(7);
//             break;
//         case '8':
//             values.Add(8);
//             break;
//         case '9':
//             values.Add(9);
//             break;
//         default:
//             values.Add(10);
//             break;
//     }

// }








