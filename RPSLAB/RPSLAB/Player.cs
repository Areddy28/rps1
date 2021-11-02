using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLAB
{
    public enum RPSnum
    {
        Rock,
        Paper,
        Scissors
    }


    abstract class Player
    {
        
        public string Name { get; set; }

       

        public RPSnum RPS { get; set; }

        public Player()
        {

        }

        public abstract RPSnum GenerateRPS(); 

    }
}
