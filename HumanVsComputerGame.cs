using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

        public class HumanVsComputerGame : IGame
        {
            private IPlayer humanPlayer;
            private IPlayer aIPlayer;
            
            public HumanVsComputerGame()
            {
                humanPlayer = new HumanPlayer();
                aIPlayer = new RandomPlayer();
            }

            public void Play()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.WriteLine("Enter your move: Rock/Paper/Scissors");
                string humanMove = Console.ReadLine().ToLower();
                string aIMove = aIPlayer.GetMove();

                Console.WriteLine("Your chose " + humanMove);
                Console.WriteLine("Computer chose " + aIMove);

                string result = DetermineWinner(humanMove, aIMove);
                Console.WriteLine(result);
            }
            private string DetermineWinner(string humanMove, string aIMove)
            {
                if (humanMove == aIMove)
                {
                    return "It´s a tie!";
                }
                else if (( aIMove == "rock" && humanMove== "scissors") ||
                        (aIMove == "paper" && humanMove == "rock") ||
                        (aIMove == "scissors" && humanMove == "paper"))
                {
                    return "You win!";
                }
                else
                {
                    return "Computer wins!";
                }
            }
        }
    }

