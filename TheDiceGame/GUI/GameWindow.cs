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
        private int roundNumber = 1;
        public List<Player> players { get; } = new List<Player>();
        private string message;
        private DiceRound diceRound;
        public GameWindow(int x, int widht, int y, int height, char borderChar, int roundNumber) : base(x, widht, y, height, borderChar)
        {
            this.roundNumber = roundNumber;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RollDice(Player player)
        {
            diceRound = new DiceRound(player);
            diceRound.Dice();
            message = $"{player.Name} has rolled {diceRound.DiceResult}.";
            PrepareTitle();
            scoreBoard = new ScoreBoard(5, 60, 3, 25, players, 1);
        }
        private void PrepareTitle()
        {
            title=  new TextLine(40, 50, 10, message);
        }

        public override void Render()
        {
            base.Render();
            scoreBoard.Render();
            title.Render();
            Console.SetCursorPosition(0, 0);
        }
    }
}
