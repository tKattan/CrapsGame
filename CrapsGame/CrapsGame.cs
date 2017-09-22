using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    class CrapsGame
    {
        //random number generator to use in method rollDice
        private static Random randomNumbers = new Random();

        //enumeration with constants that represent the game status
        public enum Status { CONTINUE, WON, LOST }

        //enumeration with constants that represent common rolls of the dice
        private enum DiceNames
        {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,
            YoLeven = 11,
            BoxCars = 12
        }//end enum DiceNames

        public int MyPoint { get; set; } = 0;//point if no win or loss on first roll
        private Status gameStatus;//can contain CONTINUE, WON or LOST

        //constructor
        public CrapsGame()
        {
        }//end constructor

        //method ReInitialize
        public void ReInitialize()
        {
            MyPoint = 0;
        }

        //method FirstRoll
        public Status FirstRoll(int diceScore)
        {
            //determine game status and point based on first roll
            switch ((DiceNames) diceScore)
            {
                case DiceNames.Seven://win with 7 on first roll
                case DiceNames.YoLeven://win with 11 on first roll
                    gameStatus = Status.WON;
                    break;
                case DiceNames.SnakeEyes://lose with 2 on first roll
                case DiceNames.Trey://lose with 3 on first roll
                case DiceNames.BoxCars://lose with 12 on first roll
                    gameStatus = Status.LOST;
                    break;
                default://did not win or lose, so remember point
                    gameStatus = Status.CONTINUE;
                    MyPoint = diceScore;//remember the point
                    break;
            }//end switch

            return gameStatus;
        }//end method FirstRoll

        //method NextRoll
        public Status NextRoll(int diceScore)
        {
            if (diceScore == MyPoint)
            {
                gameStatus = Status.WON;
            }//end if
            else if (diceScore == (int)DiceNames.Seven)
            {
                gameStatus = Status.LOST;
            }//end if

            return gameStatus;
        }//end method NextRoll

        //method RollDice
        public int[] RollDice()
        {
            int die1 = randomNumbers.Next(1, 7);//first die roll
            int die2 = randomNumbers.Next(1, 7);//second die roll

            int[] dice = { die1, die2, die1 + die2};
            return dice;
        }
    }//end class Craps
}//end namespace CrapsGame
