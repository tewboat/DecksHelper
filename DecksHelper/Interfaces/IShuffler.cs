using DeckManager.Entities;

namespace DeckManager
{
    using System.Collections.Generic;

    public interface IShuffler
    {
        void Shuffle(List<Card> cards);
    }
}