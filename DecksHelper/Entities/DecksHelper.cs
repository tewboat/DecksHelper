using System;
using System.Collections.Generic;
using System.Linq;
using DeckManager.Entities;

namespace DeckManager
{
    public class DecksHelper : IDecksHelper
    {
        private readonly Dictionary<string, Deck> decks;

        public DecksHelper()
        {
            decks = new Dictionary<string, Deck>();
        }

        public void CreateDeck(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (decks.ContainsKey(name))
                throw new ArgumentException("There is already a deck with same name.", nameof(name));
            decks.Add(name, new Deck(name));
        }

        public bool DeleteDeck(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            return decks.Remove(name);
        }

        public string[] GetAllDeckNames()
        {
            return decks.Keys.ToArray();
        }

        public Deck GetDeckByName(string name)
        {
            return decks.ContainsKey(name) 
                ? decks[name] 
                : throw new KeyNotFoundException($"There is not deck with that name: {name}");
        }
    }
}