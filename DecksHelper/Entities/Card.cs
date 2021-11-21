using DeckManager.Enums;

namespace DeckManager
{
    public class Card : ICard
    {
        public CardSuit Suit { get; }
        public CardValue Value { get; }

        internal Card(CardSuit cardSuit, CardValue value)
        {
            Suit = cardSuit;
            Value = value;
        }

        public override string ToString() =>
            $"{Suit} {Value}";
    }
}