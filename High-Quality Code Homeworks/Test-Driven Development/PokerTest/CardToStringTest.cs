using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void TestAceClubs()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Clubs);
            string cardToString = card.ToString();
            Assert.AreEqual("A♣", cardToString, "ToString() method in class Card is not working correctly.");
        }

        [TestMethod]
        public void TestTenClubs()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Clubs);
            string cardToString = card.ToString();
            Assert.AreEqual("10♣", cardToString, "ToString() method in class Card is not working correctly.");
        }

        [TestMethod]
        public void TestTwoDiamonds()
        {
            Card card = new Card(CardFace.Two, CardSuit.Diamonds);
            string cardToString = card.ToString();
            Assert.AreEqual("2♦", cardToString, "ToString() method in class Card is not working correctly.");
        }

        [TestMethod]
        public void TestJackHearts()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Hearts);
            string cardToString = card.ToString();
            Assert.AreEqual("J♥", cardToString, "ToString() method in class Card is not working correctly.");
        }

        [TestMethod]
        public void TestFiveSpades()
        {
            Card card = new Card(CardFace.Five, CardSuit.Spades);
            string cardToString = card.ToString();
            Assert.AreEqual("5♠", cardToString, "ToString() method in class Card is not working correctly.");
        }
    }
}
