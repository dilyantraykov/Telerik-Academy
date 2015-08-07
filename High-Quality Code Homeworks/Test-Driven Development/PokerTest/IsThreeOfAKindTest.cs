using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class IsThreeOfAKindTest
    {
        [TestMethod]
        public void TestIsThreeOfAKindValid()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isThreeOfAKind = poker.IsThreeOfAKind(hand);
            Assert.AreEqual(true, isThreeOfAKind, "IsThreeOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsThreeOfAKindLessCards()
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
            bool isThreeOfAKind = poker.IsThreeOfAKind(hand);
            Assert.AreEqual(false, isThreeOfAKind, "IsThreeOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsThreeOfAKindMoreCards()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);
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
            bool isThreeOfAKind = poker.IsThreeOfAKind(hand);
            Assert.AreEqual(false, isThreeOfAKind, "IsThreeOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsThreeOfAKind()
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
            bool isThreeOfAKind = poker.IsThreeOfAKind(hand);
            Assert.AreEqual(false, isThreeOfAKind, "IsThreeOfAKind() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsThreeOfAKindSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Hearts);
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
            bool isThreeOfAKind = poker.IsThreeOfAKind(hand);
            Assert.AreEqual(false, isThreeOfAKind, "IsThreeOfAKind() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
