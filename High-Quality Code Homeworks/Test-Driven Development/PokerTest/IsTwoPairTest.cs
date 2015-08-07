using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsTwoPairTest
    {
        [TestMethod]
        public void TestIsTwoPairValid()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Seven, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(true, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsTwoPairLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(false, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsTwoPairMoreCards()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Two, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardSix = new Card(CardFace.Ten, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            cards.Add(cardSix);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(false, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsTwoPair()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(false, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsTwoPairOnePairs()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFour = new Card(CardFace.King, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(false, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsTwoPairSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Queen, CardSuit.Clubs);
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
            bool isTwoPair = poker.IsTwoPair(hand);
            Assert.AreEqual(false, isTwoPair, "IsTwoPair() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
