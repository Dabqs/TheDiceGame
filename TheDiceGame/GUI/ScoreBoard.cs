using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;

namespace TheDiceGame.GUI
{
    class ScoreBoard : GuiObject
    {
        private TextBlock scoreBoard;
        public ScoreBoard(int x, int widht, int y, int height,List<Player> players) : base(x, widht, y, height)
        {
            List<string> infoMessage = new List<string>();
            foreach (Player player in players)
            {
                infoMessage.Add($"{player.Name} has {player.Score} points.");
            }
            scoreBoard = new TextBlock(X, Width, Y, infoMessage, true);
        }

        public override void Render()
        {
            scoreBoard.Render();
        }
    }
}
