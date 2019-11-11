using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game_Net
{
    class Dealer : BasePlayer
    {
        private const string DEALER_NAME = "Mr. Dealer";
        public override string GetName()
        {
            return DEALER_NAME;
        }

        public override bool WantCard()
        {
            return CountPoints() < 17;
            /*if (CountPoints() >= 17)
            {
                return false;
            }
            else
            {
                return true;
            }*/
        }
    }
}
