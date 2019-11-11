using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_Game_Net
{
    public abstract class BasePlayer : IBlackjackPlayer 
    {
        protected string Name { get; set; }
        protected List<Card> Cards { get; set; }
        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }
        public List<Card> GetCards()
        {
            return Cards;
        }
        //Counts total points of player's cards
        // If total points id over 21 & player has 'Ace', remove 10 points for each Ace until ponts <=21, 
        //or no more acess
        public int CountPoints()
        {
            int points = Cards.Sum(c => c.GetPoints());
            if (points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);
                while (aceCount > 0 && points > 21)
                {
                    points -= 10;
                    aceCount--;
                }
            }
            return points;
        }
        public virtual bool IsGameCompleted()
        {
            return CountPoints() >= 21;
        }
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
        }
        public abstract string GetName();
        public abstract bool WantCard();


    }
}