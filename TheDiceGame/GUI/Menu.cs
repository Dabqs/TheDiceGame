using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class Menu : Window
    {
        private TextBlock title;
        public Menu(int x, int widht, int y, int height, char borderChar, List<string> title) : base(x, widht, y, height, borderChar)
        {
            this.title = new TextBlock(10, 100, 5, title);
        }
        public override void Render()
        {
            base.Render();
            title.Render();
        }

    }
}
