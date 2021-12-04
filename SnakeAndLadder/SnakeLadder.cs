using System;
using System.Collections.Generic;
using System.Text;
namespace SnakeAndLadder
{
    class SnakeAndLadder  
    {
        private int PlayerPosition;
        private Random objRandom;
        private int DieRolled;

        public SnakeAndLadder()
        {
            objRandom = new Random();
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position{0}", PlayerPosition);
            RollADie();
        }
        private void RollADie() 
        {
             DieRolled = objRandom.Next(1, 7);
            Console.WriteLine("Dice Rolled: {0}", DieRolled);
            PlayerPosition = PlayerPosition + DieRolled;
            Console.WriteLine("Player Position {0}", PlayerPosition);
        }
    }
}