using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Deck
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public string Cards { get; set; }
        public int ValueDeck { get; set; }

        public List<string> suit = new List<string>() { "Spades", "Diamonds", "Hearts", "Clubs" };
        public List<string> face = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public List<string> cards = new List<string>();


        public string AllCards()
        {

            for (var suitindex = 0; suitindex < suit.Count; suitindex++)
            {
                for (var faceindex = 0; faceindex < face.Count; faceindex++)
                {
                    cards.Add($"{face[faceindex]} of {suit[suitindex]}");

                }
            }

        }


        class Program
        {
            static void Displaygame()
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to BlackJack: A Game of Chances and Struggle");
                Console.WriteLine();
            }
            // static string BeginPrompt(string prompt)
            // {
            //     Console.Write(prompt);
            //     var beginques = Console.ReadLine().ToLower();
            //     if (beginques == "yes")
            //     {
            //         foreach (var card in playerhand)
            //         {
            //             Console.WriteLine($"Your hand is {card}");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Okay no game today.");
            //     }
            // }

            static void Main(string[] args)
            {

                var suitList = new List<string>() { "Spades", "Diamonds", "Hearts", "Clubs" };
                var faceList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

                //  Creating the Deck Of cards
                var deckOfCards = new List<string>();
                for (var suitindex = 0; suitindex < suitList.Count; suitindex++)
                {
                    for (var faceindex = 0; faceindex < faceList.Count; faceindex++)
                    {
                        deckOfCards.Add($"{faceList[faceindex]} of {suitList[suitindex]}");
                    }
                    //  Shuffling
                    var numOfCards = deckOfCards.Count;
                    for (var rightindex = numOfCards - 1; rightindex >= 0; rightindex--)
                    {
                        var leftindex = new Random().Next(0, rightindex);
                        var leftNum = deckOfCards[leftindex];
                        var rightNum = deckOfCards[rightindex];
                        deckOfCards[rightindex] = leftNum;
                        deckOfCards[leftindex] = rightNum;
                    }
                    // foreach (var shufCards in deckOfCards)
                    // {
                    //     Console.WriteLine($"{shufCards}");
                    //     var newDeck = shufCards;
                    // }
                }
                var valueDeck = deckOfCards;

                var values = new List<int>();

                foreach (var face in valueDeck)
                {
                    switch (face[0])
                    {
                        case 'A':
                            values.Add(11);
                            break;
                        case 'K':
                        case 'Q':
                        case 'J':
                            values.Add(10);
                            break;
                        case '2':
                            values.Add(2);
                            break;
                        case '3':
                            values.Add(3);
                            break;
                        case '4':
                            values.Add(4);
                            break;
                        case '5':
                            values.Add(3);
                            break;
                        case '6':
                            values.Add(6);
                            break;
                        case '7':
                            values.Add(7);
                            break;
                        case '8':
                            values.Add(8);
                            break;
                        case '9':
                            values.Add(9);
                            break;
                        default:
                            values.Add(10);
                            break;
                    }

                }
                foreach (var change in values)
                {
                    Console.WriteLine(change);
                }

                // List<int> intList = stringList.ConvertAll(int.Parse)



                //  Creating new lists for hands 
                var playerhand = new List<string>() { deckOfCards[0], deckOfCards[1] };

                var househand = new List<string>() { deckOfCards[2], deckOfCards[3] };

                // Removing cards from deck
                for (var removedCard = 0; removedCard < 4; removedCard++)
                {
                    deckOfCards.Remove(deckOfCards[0]);
                }



                Console.Write("Are you ready to play? Yes or No?");
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
                }

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


                //  Printing out new removed deck
                // foreach (var cards in deckOfCards)
                // {
                //     Console.WriteLine(cards);

                // }

                //  Trying to add a hand to my list
                // playerhand.Add(deckOfCards[0]);
                // playerhand.Add(deckOfCards[1]);

                // for (var hand = 0; hand < playerhand.Count; hand++)
                // {
                //     Console.WriteLine($"players hand {playerhand[hand]}");

                // }



            }
        }
    }