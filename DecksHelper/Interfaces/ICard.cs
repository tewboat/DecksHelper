using DeckManager.Enums;

namespace DeckManager
{
    public interface ICard
    {
        CardSuit Suit { get; }
        CardValue Value { get; }
    }
}