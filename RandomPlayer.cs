using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RandomPlayer : IPlayer
    {
        private string[] moves = { "rock", "paper", "scissors" };
        private Random random;

        public RandomPlayer()
        {
            random = new Random();
        }
        public string GetMove()
        {
            int index = random.Next(moves.Length);
            return moves[index];
        }
    }
}
