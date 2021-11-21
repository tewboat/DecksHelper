using DeckManager.Entities;

namespace DeckManager
{
    public interface IDecksHelper
    {
        void CreateDeck(string name);
        bool DeleteDeck(string name);
        string[] GetAllDeckNames();
        Deck GetDeckByName(string name);
    }
}