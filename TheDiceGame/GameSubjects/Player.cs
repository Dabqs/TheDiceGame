using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GameSubjects
{
    class Player
    {
        public int Score { get; private set; }
        private string name;
        public int turnsCount { get; private set; } = 0;
        private Dice dice = new Dice();

        public Player(string name)
        {
            this.name = name;
            Score = 0;
        }
        public void RollDice()
        {
            turnsCount++;
            Score += dice.Roll();
        }
        
    }
}
