using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsStraightFlushTest
    {
        [TestMethod]
        public void TestIsStraightFlushValid()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Four, CardSuit.Clubs);
            Card cardFour = new Card(CardFace.Five, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Six, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(true, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlushStraight()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Four, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Five, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Six, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(false, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlushFlush()
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
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(false, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlushLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Four, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Three, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(false, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlush()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.King, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Clubs);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Two, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(false, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlushNotArangedCards()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.King, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(true, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightFlushOtherCombination()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.King, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(hand);
            Assert.AreEqual(false, isStraightFlush, "IsStraightFlush() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
