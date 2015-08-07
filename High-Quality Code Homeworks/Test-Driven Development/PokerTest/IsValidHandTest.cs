using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsValidHandTest
    {
        [TestMethod]
        public void TestIsValidHand()
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
            bool isValidHand = poker.IsValidHand(hand);
            Assert.AreEqual(true, isValidHand, "IsValidHand() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsValidHandLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isValidHand = poker.IsValidHand(hand);
            Assert.AreEqual(false, isValidHand, "IsValidHand() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsValidHandMoreCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardSix = new Card(CardFace.Seven, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            cards.Add(cardSix);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isValidHand = poker.IsValidHand(hand);
            Assert.AreEqual(false, isValidHand, "IsValidHand() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsValidHandSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
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
            bool isValidHand = poker.IsValidHand(hand);
            Assert.AreEqual(false, isValidHand, "IsValidHand() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
