using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsFourOfAKindTest
    {
        [TestMethod]
        public void TestIsFourOfAKindValid()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
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
            bool isFourOfAKind = poker.IsFourOfAKind(hand);
            Assert.AreEqual(true, isFourOfAKind, "IsFourOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKindLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Two, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFourOfAKind = poker.IsFourOfAKind(hand);
            Assert.AreEqual(false, isFourOfAKind, "IsFourOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKind()
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
            bool isFourOfAKind = poker.IsFourOfAKind(hand);
            Assert.AreEqual(false, isFourOfAKind, "IsFourOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKindSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
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
            bool isFourOfAKind = poker.IsFourOfAKind(hand);
            Assert.AreEqual(false, isFourOfAKind, "IsFourOfAKind() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
