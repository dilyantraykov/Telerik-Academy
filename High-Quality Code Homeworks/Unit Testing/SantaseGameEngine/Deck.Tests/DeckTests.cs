using NUnit.Framework;
using Santase.Logic.Cards;

namespace DeckNUnitTests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void TestCountOfCardsInNewDeckInstanceIsGreaterThanZero()
        {
            Deck gameDeck = new Deck();
            int initialCardsCount = gameDeck.CardsLeft;
            Assert.Greater(initialCardsCount, 0);
        }
        [Test]
        public void TestNextCardGotFromTheDeckIsNotNull()
        {
            Deck gameDeck = new Deck();
            int initialCardsCount = gameDeck.CardsLeft;
            Assert.Greater(initialCardsCount, 0);
            Card nextCard = gameDeck.GetNextCard();
            Assert.IsNotNull(nextCard);
        }

        [Test]
        public void TestValidCardsCountAfterGettingTheNextCardFromTheDeck()
        {
            Deck gameDeck = new Deck();
            int initialCardsCount = gameDeck.CardsLeft;
            Card nextCard = gameDeck.GetNextCard();
            Assert.AreEqual(initialCardsCount - 1, gameDeck.CardsLeft);
        }

        [Test]
        [ExpectedException(typeof(Santase.Logic.InternalGameException))]
        public void TestGetNextCardFromEmptyDeckThrowsException()
        {
            Deck deck = new Deck();
            int cardsCount = deck.CardsLeft;
            Card card = deck.GetNextCard();
            for (int i = 1; i <= cardsCount; i++)
            {
                card = deck.GetNextCard();
            }
        }

        [Test]
        public void TestTrumpCardIsAtTheTopOfDeck()
        {
            Deck deck = new Deck();
            int cardsCount = deck.CardsLeft;
            Card topCard = deck.GetNextCard();
            for (int i = 1; i < cardsCount; i++)
            {
                topCard = deck.GetNextCard();
            }
            Assert.AreEqual(topCard, deck.GetTrumpCard);
            Assert.AreSame(topCard, deck.GetTrumpCard);
        }

        [Test]
        [TestCase(CardSuit.Spade, CardType.King)]
        [TestCase(CardSuit.Heart, CardType.Ace)]
        [TestCase(CardSuit.Diamond, CardType.Jack)]
        [TestCase(CardSuit.Heart, CardType.Queen)]
        [TestCase(CardSuit.Diamond, CardType.Ten)]
        public void TestChangeTrumpCardShouldProperlyUpdateBothTrumpCardAndDeckTopCard(CardSuit suit, CardType type)
        {
            Deck deck = new Deck();
            Card newTrumpCard = new Card(suit, type);
            deck.ChangeTrumpCard(newTrumpCard);
            int cardsCount = deck.CardsLeft;
            Card topCard = deck.GetNextCard();
            for (int i = 1; i < cardsCount; i++)
            {
                topCard = deck.GetNextCard();
            }
            Assert.AreEqual(topCard, newTrumpCard);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(24)]
        public void TestGettingCardsFromDeckShouldProperlyUpdateTheCountOfCardsLeft(int countOfCardsToGet)
        {
            Deck deck = new Deck();
            Card card = deck.GetNextCard();
            int cardsLeftCount = deck.CardsLeft;
            for (int i = 1; i < countOfCardsToGet; i++)
            {
                card = deck.GetNextCard();
                cardsLeftCount--;
            }
            Assert.AreEqual(deck.CardsLeft, cardsLeftCount);
        }
    }
}