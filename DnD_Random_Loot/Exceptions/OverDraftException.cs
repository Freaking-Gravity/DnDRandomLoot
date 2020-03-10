using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_Random_Loot
{
    class OverDraftException : Exception
    {
        public OverDraftException() :
    base("You have gone over your current wallet amount. Please make more money before trying to spend more than you have.")
        {
            //empty body
        }
        public OverDraftException(string messageValue) :
            base(messageValue)
        {
            //Empty body again
        }
        public OverDraftException(string messageValue, Exception inner) :
            base(messageValue, inner)
        {
            //Empty body again again
        }
    }
}
