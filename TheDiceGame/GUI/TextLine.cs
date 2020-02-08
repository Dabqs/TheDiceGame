using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class TextLine: GuiObject
    {
        private bool useLeftTextAllignment;
        public TextLine(int x, int widht, int y, string label, bool useLeftTextAllignment = false) : base(x, widht, y, 1)
        {
            this.useLeftTextAllignment = useLeftTextAllignment;
            Label = label;
        }

        public string Label { get; internal set; }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);

            if (Width > Label.Length)
            {
                int offset = useLeftTextAllignment? 0 : (Width - Label.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            for (int i = 0; i < Label.Length; i++)
            {
                if (i <= Width)
                {
                    Console.Write(Label[i]);
                }
            }
        }
    }
}
