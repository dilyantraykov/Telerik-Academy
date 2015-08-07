using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsOnePairTest
    {
        [TestMethod]
        public void TestIsOnePairValid()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Seven, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Queen, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isOnePair = poker.IsOnePair(hand);
            Assert.AreEqual(true, isOnePair, "IsOnePair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsOnePairLessCards()
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
            bool isOnePair = poker.IsOnePair(hand);
            Assert.AreEqual(false, isOnePair, "IsOnePair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsOnePair()
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
            bool isOnePair = poker.IsOnePair(hand);
            Assert.AreEqual(false, isOnePair, "IsOnePair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsOnePairTwoPairs()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isOnePair = poker.IsOnePair(hand);
            Assert.AreEqual(false, isOnePair, "IsOnePair() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsOnePairSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Diamonds);
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
            bool isOnePair = poker.IsOnePair(hand);
            Assert.AreEqual(false, isOnePair, "IsOnePair() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
