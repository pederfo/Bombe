using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombe
{
    class Game
    {
        public void Play()
        {
            var arena = new Arena();
            arena.DrawMap();
        }
    }
}
