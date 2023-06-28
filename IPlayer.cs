using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public interface IPlayer //Strategy Interface för spelarens strategi
    {
       string GetMove();
    }
}
