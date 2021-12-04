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
        private Dictionary<int, int> dictLadders;
        private Dictionary<int, int> dictSnakes; 

        public SnakeAndLadder()
        {
            objRandom = new Random();
            dictLadders = new Dictionary<int, int>()
            {
                {5, 1}, {11, 1}, {23, 1}, {44, 1}, {67,1}, {82, 1}, {89, 1}
            };
            dictSnakes = new Dictionary<int, int>()
            {
                 {12, 1}, {26, 1}, {35, 1}, {77, 1}, {84,1}, {96, 1}, {99, 1}
            };
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position {0}", PlayerPosition);
            while (true)
            {
                RollADie();
                if (PlayerPosition > 100)
                {
                    PlayerPosition = PlayerPosition - DieRolled;
                }
                Console.WriteLine("Player Position {0}", PlayerPosition);
                CheckOptions();
                if (ExactWinner()) 
                {
                    break;
                }
               
            }
        }
        private void RollADie() 
        {
            DieRolled = objRandom.Next(7);
            Console.WriteLine("Dice Rolled: {0}", DieRolled);
            PlayerPosition = PlayerPosition + DieRolled;
          
        }
        private void CheckOptions() 
        {
            int ladder, snakeBite;
            dictLadders.TryGetValue(PlayerPosition, out ladder);
            if (ladder > 0)
            {
                Console.WriteLine("Ladder: +{0}", DieRolled);
                PlayerPosition = PlayerPosition + DieRolled;
                Console.WriteLine("Player Position {0}", PlayerPosition);

            }
            dictSnakes.TryGetValue(PlayerPosition, out snakeBite);
            if(snakeBite > 0)
            { 
                Console.WriteLine("Snake Bite: -{0}",DieRolled);
                PlayerPosition = PlayerPosition - DieRolled;
                Console.WriteLine("Player Position {0}", PlayerPosition);

            }
           
        }
        public bool ExactWinner() 
        {
            
            if (PlayerPosition == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}