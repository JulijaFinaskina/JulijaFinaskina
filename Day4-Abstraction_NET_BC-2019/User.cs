using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction_NET_BC_2019
{
    public class User : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetText("Enter your name: ");
        }

        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("Enter positive integer: ");
            return CurrentGuess;
        }
    }

    public class ConsoleInput
    {
        internal static int GetInt(string v)
        {
            throw new NotImplementedException();
        }

        internal static string GetText(string v)
        {
            throw new NotImplementedException();
        }
    }
}
