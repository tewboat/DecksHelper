using System;
using System.Collections.Generic;
using DeckManager.Enums;

namespace DeckManager.Entities
{
    public class Deck : IDeck
    {
        public int Count => cards.Count;
        public string Name { get; }

        private List<Card> cards;

        internal Deck(string name)
        {
            Name = name;

            var suits = Enum.GetValues(typeof(CardSuit));
            var values = Enum.GetValues(typeof(CardValue));

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card((CardSuit)suit, (CardValue)value));
                }
            }
        }
        
        public void Shuffle(IShuffler shuffler)
        {
            if (shuffler == null)
                throw new NullReferenceException("Shuffle argument must not be null"); 
            shuffler.Shuffle(cards);
        }
    }
}