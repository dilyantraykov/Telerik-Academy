using System;

class PokerMitko
{
    static void Main()
    {
        string[] cards = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        string[] hand = new string[5];
        for (int i = 0; i < 5; i++)
        {
            hand[i] = Console.ReadLine();
        }
        int[] cardIndexes = new int[5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if (hand[i] == cards[j])
                {
                    cardIndexes[i] = j;
                }
            }
        }
        Array.Sort(cardIndexes);
        bool straight = true;
        for (int i = 0; i < 4; i++)
        {
            if (cardIndexes[i] + 1 != cardIndexes[i+1])
            {
                straight = false;
            }
        }
        if (!straight && cardIndexes[0] == 0)
        {
            straight = true;
            cardIndexes[0] = 13;
            Array.Sort(cardIndexes);
            for (int i = 0; i < 4; i++)
            {
                if (cardIndexes[i] + 1 != cardIndexes[i + 1])
                {
                    straight = false;
                }
            }
        }
        bool impossible = false;
        bool pair = false;
        bool twoPair = false;
        bool threeOfAKind = false;
        bool fourOfAKind = false;
        int pairCount = 0;
        if (!straight)
        {
            for (int i = 0; i < 4; i++)
            {
                pairCount = 0;
                for (int j = i + 1; j < 5; j++)
                {
                    if (hand[i] == hand[j] && hand[i] != "X")
                    {
                        hand[j] = "X";
                        pairCount++;
                    }
                }
                if (pair && pairCount == 1)
                {
                    twoPair = true;
                }
                else if (pairCount == 1)
                {
                    pair = true;
                }
                else if (pairCount == 2)
                {
                    threeOfAKind = true;
                }
                else if (pairCount == 3)
                {
                    fourOfAKind = true;
                }
                else if (pairCount == 4)
                {
                    impossible = true;
                }
            }
        }
        if (straight)
        {
            Console.WriteLine("Straight");
        }
        else if (impossible)
        {
            Console.WriteLine("Impossible");
        }
        else if (fourOfAKind)
        {
            Console.WriteLine("Four of a Kind");
        }
        else if (threeOfAKind && pair)
        {
            Console.WriteLine("Full House");
        }
        else if (threeOfAKind)
        {
            Console.WriteLine("Three of a Kind");
        }
        else if (twoPair)
        {
            Console.WriteLine("Two Pairs");
        }
        else if (pair)
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}
