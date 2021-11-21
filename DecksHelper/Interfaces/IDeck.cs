using System.Collections.Generic;

namespace DeckManager
{
    public interface IDeck
    {
        int Count { get; }
        string Name { get; }
        void Shuffle(IShuffler shuffler);
    }
}