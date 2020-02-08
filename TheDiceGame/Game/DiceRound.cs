using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;

namespace TheDiceGame.Game
{

    class DiceRound
    {
        public int DiceResult { get; set; }
        private Player player;
        private Dice dice;
        
        public DiceRound(Player player)
        {
            this.player = player;
        }

        public void Dice()
        {
            DiceResult = dice.Roll();
            player.Score += DiceResult;
        }
    }
}
