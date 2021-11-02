using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLAB
{
    class Rocky : Player 
    {
        public Rocky()
        {
            Name = "Rocky"; 
        }
        public override RPSnum GenerateRPS()
        {
            return RPSnum.Rock; 
        }
    }
}
