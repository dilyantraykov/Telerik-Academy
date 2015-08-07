using System;
using System.Collections.Generic;

// Implement IHand interface to class Hand
// Create method ToString and OrderHand based on classes HandToStringTest and HandOrderHandTest
namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public ICard[] OrderHand()
        {
            ICard[] array = new ICard[this.Cards.Count];
            for (int count = 0; count < this.Cards.Count; count++)
            {
                array[count] = this.Cards[count];
            }

            Array.Sort(array, delegate(ICard x, ICard y) { return x.Face.CompareTo(y.Face); });
            return array;
        }

        public override string ToString()
        {
            string handToString = string.Empty;
            for (int count = 0; count < this.Cards.Count; count++)
            {
                ICard current = this.Cards[count];
                handToString += current.ToString();
            }

            return handToString;
        }
    }
}
