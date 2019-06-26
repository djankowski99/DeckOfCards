using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        private static string[] ranks = new string[] {"Ace","2","3","4","5","6",
           "7","8","9","10","Jack","Queen","King" };
        private static string[] suits = new string[] { "Hearts", "Clubs", "Spades", "Diamonds" };
        private int _suit;
        private int _rank;

        private string rank
        {
            get
            {
                return ranks[_rank];

            }
        }
        private string suit
        {
            get
            {
                return suits[_suit];

            }
        }
        public Card(int rank,int suit)
        {
            this._suit = suit;
            this._rank = rank;
        }

       public string ToString()
        {
            return rank + " of " + suit;
        }
       
        
        
    }
}
