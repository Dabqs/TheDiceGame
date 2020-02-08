using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class Window : GuiObject
    {
        private Frame frame;
        public Window(int x, int widht, int y, int height, char borderChar) : base(x, widht, y, height)
        {
            frame = new Frame(x, widht, y, height, borderChar);
        }

        public override void Render()
        {
            frame.Render();
        }
    }
}
