using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GameSubjects
{
    class Dice
    {
        private Random result = new Random();

        public int Roll()
        {
            return result.Next(1, 7);
        }
        public void Render()
        {

        }

    }
}