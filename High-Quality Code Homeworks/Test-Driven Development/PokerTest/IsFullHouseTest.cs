using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsFullHouseTest
    {
        [TestMethod]
        public void TestIsFullHouseValid()
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
            bool isFullHouse = poker.IsFullHouse(hand);
            Assert.AreEqual(true, isFullHouse, "IsFullHouse() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFullHouseLessCards()
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
            bool isFullHouse = poker.IsFullHouse(hand);
            Assert.AreEqual(false, isFullHouse, "IsFullHouse() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFullHouse()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
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
            bool isFullHouse = poker.IsFullHouse(hand);
            Assert.AreEqual(false, isFullHouse, "IsFullHouse() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFullHouseTwoPairs()
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
            bool isFullHouse = poker.IsFullHouse(hand);
            Assert.AreEqual(false, isFullHouse, "IsFullHouse() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsFulHouseSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Clubs);
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
            bool isFullHouse = poker.IsFullHouse(hand);
            Assert.AreEqual(false, isFullHouse, "IsFullHouse() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
