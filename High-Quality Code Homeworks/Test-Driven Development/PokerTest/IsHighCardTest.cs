using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsHighCardTest
    {
        [TestMethod]
        public void TestIsHighCardValid()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Seven, CardSuit.Clubs);
            Card cardFour = new Card(CardFace.Queen, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Hearts);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(true, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsHighCardStraightFlush()
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
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(false, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsHighCardStraight()
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
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(false, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsHighCardFlush()
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
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(false, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsHighCardLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Four, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(false, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsHighCard()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.King, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Clubs);
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
            bool isHighCard = poker.IsHighCard(hand);
            Assert.AreEqual(false, isHighCard, "IsHighCard() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
