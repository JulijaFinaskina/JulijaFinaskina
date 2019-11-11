using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Abstraction_NET_BC_2019
{
    /// <summary>
    /// Abstract class of all methods that need to be realised 
    /// </summary>
    public abstract class BasePlayer : IPlayer
    {
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        /// <summary>
        /// Constructor of players
        /// </summary>
        public BasePlayer()
        {
            Name = GetName();
        }
        public abstract string GetName();

        public abstract int GuessNumber();

        public virtual bool IsNumberGuessed(int number)
        {
            if (number > CurrentGuess)
            {
                Console.WriteLine("{0} is less than the number!", CurrentGuess);
                NextGuess = 1;
            }
            else if (number < CurrentGuess)
            {
                Console.WriteLine("{0} is greater than the number!", CurrentGuess);
                NextGuess = -1;
            }
            return (number == CurrentGuess);
        }

    }

    public class IPlayer
    {
        internal void GuessNumber()
        {
            throw new NotImplementedException();
        }

        internal bool IsNumberGuessed(int currentNumber)
        {
            throw new NotImplementedException();
        }

        internal int GetName()
        {
            throw new NotImplementedException();
        }
    }
}

