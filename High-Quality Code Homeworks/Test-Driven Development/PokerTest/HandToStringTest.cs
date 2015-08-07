using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandToStringTest
    {
        [TestMethod]
        public void TestEmptyHand()
        {
            Hand hand = new Hand(new List<ICard>());
            string handToString = hand.ToString();
            Assert.AreEqual(string.Empty, handToString, "ToString() method in class Hand is not working correctly.");
        }

        [TestMethod]
        public void TestSameCards()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            string handToString = hand.ToString();
            Assert.AreEqual("10♣10♣10♣", handToString, "ToString() method in class Hand is not working correctly.");
        }

        [TestMethod]
        public void TestValidHand()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            string handToString = hand.ToString();
            Assert.AreEqual("2♦J♥5♠A♣10♣", handToString, "ToString() method in class Hand is not working correctly.");
        }
    }
}
