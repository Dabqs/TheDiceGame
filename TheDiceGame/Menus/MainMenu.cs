using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class MainMenu : Menu
    {
        public MainMenu(int x, int widht, int y, int height, char borderChar, List<string> title) : base(x, widht, y, height, borderChar,title){}
        public override void Render()
        {
            base.Render();
            Console.SetCursorPosition(0,0);
        }
    }
}
