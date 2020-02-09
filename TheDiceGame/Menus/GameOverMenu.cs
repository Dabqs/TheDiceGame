using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;

namespace TheDiceGame.GUI
{
    class GameOverMenu : Menu
    {
        private TextBlock title;
        public GameOverMenu(int x, int widht, int y, int height, char borderChar,List<string> title) : base(x, widht, y, height, borderChar, title)
        {
            this.title = new TextBlock(40, 60, 5, title);
        }
        public override void Render()
        {
           base.Render();
            Console.SetCursorPosition(0,0);
        }
    }
}
