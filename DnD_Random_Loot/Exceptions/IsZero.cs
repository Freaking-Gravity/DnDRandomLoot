using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_Random_Loot
{
    class IsZero : Exception
    {
        public IsZero() :
            base("By choosing 0 as your input, you are telling me you wish to quit. Is this true?")
        {
            //empty body
        }
        public IsZero(string messageValue) : 
            base(messageValue)
        {
            //Empty body again
        }
        public IsZero(string messageValue, Exception inner) : 
            base(messageValue, inner)
        {
            //Empty body again again
        }
    }
}
