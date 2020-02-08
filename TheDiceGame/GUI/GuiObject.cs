using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    abstract class GuiObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public GuiObject(int x, int widht, int y, int height)
        {
            X = x;
            Y = y;
            Width = widht;
            Height = height;
        }

        abstract public void Render();
    }
}
