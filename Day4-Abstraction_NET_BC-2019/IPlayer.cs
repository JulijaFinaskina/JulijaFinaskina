using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction_NET_BC_2019
{
    public interface IPlayer
    {
        int GuessNumber();
        bool IsNumberGuessed(int number);
        string GetName();
    }
}


