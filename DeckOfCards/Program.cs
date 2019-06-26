using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Daniel Jankowski
//Card Game Coding Challange
//26-JUN-2019

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        { 
            Deck deck = null;
            bool playing = true;
            Console.WriteLine("Cards!");
            Console.WriteLine("Q – quit the application");
            Console.WriteLine("N – Create New Deck");
            Console.WriteLine("S – Shuffle Current Deck");
            Console.WriteLine("D - Draw Card");
            Console.WriteLine("R - Display Deck");

            while (playing)
            {
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'Q':
                    case 'q':
                        playing = false;
                        break;
                    case 'N':
                    case 'n':
                        deck = new Deck();
                        Console.WriteLine("Created new Deck.");
                        break;
                    case 'S':
                    case 's':
                        if (deck == null)
                            Console.WriteLine("No Deck");
                        else
                        {
                            deck.Shuffle();
                            Console.WriteLine("Deck Shuffled");
                        }
                        break;
                    case 'D':
                    case 'd':
                        if (deck == null)
                            Console.WriteLine("No Deck");
                        else
                        {
                            Card card = deck.DrawTopCard();
                            Console.WriteLine(card.ToString());
                        }
                        break;
                    case 'R':
                    case 'r':
                        if (deck == null)
                            Console.WriteLine("No Deck");
                        else
                        {
                            Console.WriteLine(deck.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            }

        }
    }
}
