using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsFlushTest
    {
        [TestMethod]
        public void TestIsFlush()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Five, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(hand);
            Assert.AreEqual(true, isFlush, "IsFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFlushLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Five, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(hand);
            Assert.AreEqual(false, isFlush, "IsFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFlushDifferentCards()
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
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(hand);
            Assert.AreEqual(false, isFlush, "IsFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFlushSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Five, CardSuit.Clubs);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(hand);
            Assert.AreEqual(false, isFlush, "IsFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFlushStraightFlush()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Four, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Five, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Six, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(hand);
            Assert.AreEqual(false, isFlush, "IsFlush() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
