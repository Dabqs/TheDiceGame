using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class Button : GuiObject
    {
        private TextLine textLine;
        private Frame frame;

        public bool IsActive { get; private set; } = false;
        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }
        public Button(int x, int widht, int y, int height, string buttonLabel) : base(x, widht, y, height)
        {
            frame = new Frame(x, widht, y, height);
            textLine = new TextLine(x + 1, widht -2, y +1 + ((height -2)/2), buttonLabel);
        }
        public void SetActive()
        {
            frame.SetActive();
        }
        public void Deactivate()
        {
            frame.Deactivate();
        }

        public override void Render()
        {
            frame.Render();
            textLine.Render();
        }
    }
}
