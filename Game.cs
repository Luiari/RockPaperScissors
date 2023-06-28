using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors //Factory Method som ansvarar för att skapa olika typer av spel
{
    public class Game
    {
        public IGame CreateGame()
        {
            return new HumanVsComputerGame();          
        }
    }
}
