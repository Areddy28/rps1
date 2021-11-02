using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLAB
{
    class RPSApp
    {
        public int Wins { get; set; }
        public int Loses { get; set; }
        public UserPlayer User { get; set; } = new UserPlayer();

        //We leave this property blank since we want the user to select who they play
        public Player Opponent { get; set; }


        public RPSApp()
        {
            //Later on once we have random, replace this line with code that
            //Lets the player choose their opponent
            User = new UserPlayer(); 
            Opponent = new Rocky(); 
        }



        //public Player Play()
        //{
        //     User.GenerateRPS();
        //     Opponent.GenerateRPS(); 

            
        //}
    }
}
