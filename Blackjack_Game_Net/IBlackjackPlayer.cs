using System.Collections.Generic;

namespace Blackjack_Game_Net
{
    public class IBlackjackPlayer
    {
        string GetName();
        List<Card> GetCards();
        int CountPoints();
        bool IsGameCompleted();
        bool WantCard();
        private void GiveCard(Card card);
    }
}