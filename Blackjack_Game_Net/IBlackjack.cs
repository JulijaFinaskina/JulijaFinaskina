﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game_Net
{
    public interface IBlackjackPlayer
    {
        string GetName();
        List<Card> GetCards();
        int CountPoints();
        bool IsGameCompleted();
        bool WantCard();
        void GiveCard(Card card);
    }
}

