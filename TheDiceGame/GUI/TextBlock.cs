using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class TextBlock : GuiObject
    {
        private List<TextLine> textLines = new List<TextLine>();
        public TextBlock(int x, int widht, int y, List<string> textLines) : base(x, widht, y, 0)
        {
            for (int i = 0; i < textLines.Count; i++)
            {
                this.textLines.Add(new TextLine(X, Width, Y + i, textLines[i]));
            }
        }


        public override void Render()
        {
            foreach (TextLine textLine in textLines)
            {
                textLine.Render();
            }
        }
    }
}
