using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameSingleton //Singleton för att se till att vi bara en instans av game
    {
        private static Game instance;
        private void Game() 
        {
           
        }
        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }
        
    }
}
