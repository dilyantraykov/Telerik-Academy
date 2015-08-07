using System;

// Implement ICard interface to class Card
// Create method ToString based on class CardToStringTest
namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        private string SuitToString()
        {
            string suitToString = string.Empty;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suitToString = "♣";
                    break;
                case CardSuit.Diamonds:
                    suitToString = "♦";
                    break;
                case CardSuit.Hearts:
                    suitToString = "♥";
                    break;
                case CardSuit.Spades:
                    suitToString = "♠";
                    break;
            }

            return suitToString;
        }

        public override string ToString()
        { 
            string cardToString = string.Empty;
            if ((int)this.Face <= 10)
            {
                cardToString += (int)this.Face;
                cardToString += this.SuitToString();
            }
            else
            {
                cardToString += this.Face.ToString()[0];
                cardToString += this.SuitToString();
            }

            return cardToString;
        }
    }
}
