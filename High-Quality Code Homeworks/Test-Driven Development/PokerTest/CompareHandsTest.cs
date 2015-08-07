using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CompareHandsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCompareHandsInvalidHands()
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
            Hand handOne = new Hand(cards);
            IList<ICard> lessCards = new List<ICard>();
            lessCards.Add(cardOne);
            lessCards.Add(cardTwo);
            lessCards.Add(cardThree);
            lessCards.Add(cardFour);
            Hand handTwo = new Hand(lessCards);
            PokerHandsChecker poker = new PokerHandsChecker();
            int result = poker.CompareHands(handOne, handTwo);
        }

        [TestMethod]
        public void TestCompareHandsEqualHands()
        {
            Card cardOne = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand handOne = new Hand(cards);
            Hand handTwo = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            int result = poker.CompareHands(handOne, handTwo);
            Assert.AreEqual(0, result, "CompareHands() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestCompareHandsFirstHand()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ace, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Spades);
            IList<ICard> cardsOne = new List<ICard>();
            cardsOne.Add(cardOne);
            cardsOne.Add(cardTwo);
            cardsOne.Add(cardThree);
            cardsOne.Add(cardFour);
            cardsOne.Add(cardFive);
            Hand handOne = new Hand(cardsOne);
            Card cardSix = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardSeven = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardEight = new Card(CardFace.Five, CardSuit.Spades);
            Card cardNine = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardTen = new Card(CardFace.Ten, CardSuit.Clubs);
            IList<ICard> cardsTwo = new List<ICard>();
            cardsTwo.Add(cardSix);
            cardsTwo.Add(cardSeven);
            cardsTwo.Add(cardEight);
            cardsTwo.Add(cardNine);
            cardsTwo.Add(cardTen);
            Hand handTwo = new Hand(cardsTwo);
            PokerHandsChecker poker = new PokerHandsChecker();
            int result = poker.CompareHands(handOne, handTwo);
            Assert.AreEqual(1, result, "CompareHands() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestCompareHandsSecondHand()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Spades);
            IList<ICard> cardsOne = new List<ICard>();
            cardsOne.Add(cardOne);
            cardsOne.Add(cardTwo);
            cardsOne.Add(cardThree);
            cardsOne.Add(cardFour);
            cardsOne.Add(cardFive);
            Hand handOne = new Hand(cardsOne);
            Card cardSix = new Card(CardFace.Two, CardSuit.Clubs);
            Card cardSeven = new Card(CardFace.Three, CardSuit.Clubs);
            Card cardEight = new Card(CardFace.Four, CardSuit.Clubs);
            Card cardNine = new Card(CardFace.Five, CardSuit.Clubs);
            Card cardTen = new Card(CardFace.Six, CardSuit.Clubs);
            IList<ICard> cardsTwo = new List<ICard>();
            cardsTwo.Add(cardSix);
            cardsTwo.Add(cardSeven);
            cardsTwo.Add(cardEight);
            cardsTwo.Add(cardNine);
            cardsTwo.Add(cardTen);
            Hand handTwo = new Hand(cardsTwo);
            PokerHandsChecker poker = new PokerHandsChecker();
            int result = poker.CompareHands(handOne, handTwo);
            Assert.AreEqual(-1, result, "CompareHands() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
