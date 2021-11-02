using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLAB
{
    class Randa : Player
    {
        public Randa()
        {

        }
        public override RPSnum GenerateRPS()
        {

            Random randomRPS = new Random();

            int ran = 0;
            ran = randomRPS.Next(0, 3);

            RPSnum placeHolder;
            
            switch (ran)
            {
                case 0:
                    placeHolder = RPSnum.Rock;
                    break;
                case 1:
                    placeHolder = RPSnum.Paper;
                    break;
                case 2:
                    placeHolder = RPSnum.Scissors;
                    break;
                default:
                    return GenerateRPS();

            }

            return placeHolder;




        }

    }
}
