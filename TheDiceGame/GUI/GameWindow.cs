using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.Game;
using TheDiceGame.GameSubjects;

namespace TheDiceGame.GUI
{
    class GameWindow : Window
    {
        private ScoreBoard scoreBoard;
        private TextLine title;
        private int RoundNumber = 1;
        private Player player;
        private string message;
        private DiceRound diceRound;
        public GameWindow(int x, int widht, int y, int height, char borderChar, Player player, ScoreBoard scoreBoard) : base(x, widht, y, height, borderChar)
        {
            this.player = player;
            this.scoreBoard = scoreBoard;
      
        }
        public void SetCurrentRoundInfo()
        {
            message = $"Now it's {player.Name} turn.";
            PrepareTitle();
        }
        public void SetDiceResult()
        {
            message = $"Now {player.Name} has just collected {diceRound.DiceResult} points.";
            PrepareTitle();
        }
        private void PrepareTitle()
        {
            title=  new TextLine(50, 50, 10, message);
        }

        public override void Render()
        {
            base.Render();
            scoreBoard.Render();
            Console.SetCursorPosition(0, 0);
        }
    }
}
