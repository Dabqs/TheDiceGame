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
        public int DiceCount { get; private set; } = 1;
        public DiceSelectionMenu(int x, int widht, int y, int height, char borderChar, List<string> title) : base(x, widht, y, height, borderChar, title){}

        public void IncreaseDicesCount()
        {
            DiceCount++;
        }
        public void ReduceDicesCount()
        {
            if (DiceCount > 1)
            {
            DiceCount--;
            }
        }
        public override void Render()
        {
            base.Render();
            diceText = new TextLine(X+1, Width, Y + 10, $"Players will have {DiceCount} dice");
            diceText.Render();
            Console.SetCursorPosition(0,0);
 
        }
    }
}
