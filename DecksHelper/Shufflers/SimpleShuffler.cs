using System;
using DeckManager.Entities;

namespace DeckManager
{
    using System.Collections.Generic;

    public class SimpleShuffler : IShuffler
    {
        public void Shuffle(List<Card> cards)
        {
            if (cards == null)
                throw new ArgumentNullException(nameof(cards));
            var random = new Random();
            for (var i = 0; i < cards.Count; i++)
            {
                var index = random.Next(i, cards.Count - 1);
                var temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }
        }
    }
}