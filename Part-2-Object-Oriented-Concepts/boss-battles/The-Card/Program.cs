List<Card> cards = [];

foreach (CardColor cardColor in Enum.GetValues<CardColor>())
{
    foreach (CardRank cardRank in Enum.GetValues<CardRank>())
    {
       Card newCard = new(cardColor, cardRank);
        cards.Add(newCard);
    }
}

foreach (Card card in cards)
{
    bool faceCard = card.IsFaceCard();
    Console.WriteLine($"The {card.Color} {card.Rank} - Facecard: {faceCard}");
}


public class Card(CardColor color, CardRank rank)
{
    public CardColor Color { get; set; } = color;
    public CardRank Rank { get; set; } = rank;

    public bool IsFaceCard()
    {
        if (Rank == CardRank.DollarSign || Rank == CardRank.Percent || Rank == CardRank.Carrot || Rank == CardRank.Ampersand)
        {
            return true;
        }
        return false;
    }
}

public enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow
}

public enum CardRank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    DollarSign,
    Percent,
    Carrot,
    Ampersand,

}