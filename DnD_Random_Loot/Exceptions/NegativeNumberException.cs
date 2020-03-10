using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_Random_Loot
{
    class NegativeNumberExeption : Exception
    {
        public NegativeNumberExeption() :
             base("Negative coins isn't a thing. Try again.")
        {
            //empty body?
        }
        public NegativeNumberExeption(string messageValue) : base(messageValue)
        {
            //empty body*2
        }
        public NegativeNumberExeption(string messageValue, Exception inner) : base(messageValue, inner)
        {
            //empty body*3
        }
    }
}
