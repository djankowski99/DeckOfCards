using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for(int s = 0; s < 4; s++)
            {
                for(int r = 0; r < 13; r++)
                {
                    cards.Add(new Card(r,s));
                }
            }
            //Shuffle();//shuffle in the constructer
         
        }

        public void Shuffle()
        {
            var shuffledCards = this.cards.OrderBy(c => Guid.NewGuid()).ToList();
            this.cards = shuffledCards;
        }

        public string ToString()
        {
            return string.Join(Environment.NewLine, cards.Select(x => x.ToString()));
        }

        public Card DrawTopCard()
        {
            Card card = cards.First();
            cards.Remove(cards.First());
            return card;
        }
    }
}
