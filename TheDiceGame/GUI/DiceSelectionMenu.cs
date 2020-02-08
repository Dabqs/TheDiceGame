using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class DiceSelectionMenu : Menu
    {
        private TextLine diceText;
        private int diceCount = 1;
        public DiceSelectionMenu(int x, int widht, int y, int height, char borderChar, List<string> title) : base(x, widht, y, height, borderChar, title)
        {

        }

        public void IncreaseDicesCount()
        {
            diceCount++;
        }
        public void ReduceDicesCount()
        {
            diceCount--;
        }
        public override void Render()
        {
            base.Render();
            diceText = new TextLine(X, Width, Y, $"Players will have {diceCount} dice");
            diceText.Render();
        }
    }
}
