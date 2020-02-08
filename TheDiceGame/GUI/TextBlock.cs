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
        public TextBlock(int x, int widht, int y, int height, List<string> textLines) : base(x, widht, y, height)
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
