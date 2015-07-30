namespace SuecaTypes
{
    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Queen,
        Jack,
        King,
        Seven,
        Ace
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public class Card : JsonSerializable
    {
        public Rank Rank;
        public Suit Suit;

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}
