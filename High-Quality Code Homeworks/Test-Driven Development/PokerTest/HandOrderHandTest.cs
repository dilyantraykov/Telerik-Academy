using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandOrderHandTest
    {
        [TestMethod]
        public void TestOrderHand()
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
            ICard[] array = hand.OrderHand();
            Assert.AreEqual(cardOne.Face, array[0].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardThree.Face, array[1].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardFive.Face, array[2].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardTwo.Face, array[3].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardFour.Face, array[4].Face, "OrderHand() method in class Hand is not working correctly.");
        }

        [TestMethod]
        public void TestOrderHandSameCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Jack, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Five, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ace, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            ICard[] array = hand.OrderHand();
            Assert.AreEqual(cardOne.Face, array[0].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardThree.Face, array[1].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardTwo.Face, array[2].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardFour.Face, array[3].Face, "OrderHand() method in class Hand is not working correctly.");
            Assert.AreEqual(cardFour.Face, array[4].Face, "OrderHand() method in class Hand is not working correctly.");
        }

        [TestMethod]
        public void TestOrderHandOneCard()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            Hand hand = new Hand(cards);
            ICard[] array = hand.OrderHand();
            Assert.AreEqual(cardOne.Face, array[0].Face, "OrderHand() method in class Hand is not working correctly.");
        }
    }
}
