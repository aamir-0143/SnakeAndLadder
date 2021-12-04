using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Welcome TO SNAKE AND LADDER Game=======");
            SnakeAndLadder SnakeAndLadder = new SnakeAndLadder();
            SnakeAndLadder.StartGame();
            SnakeAndLadder.CheckWinner();
            Console.WriteLine("Player Won");
        }
    }
}