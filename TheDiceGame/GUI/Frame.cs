using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class Frame : GuiObject
    {
        private char activeBorderChar = '#';
        private char inActiveBorderChar = '+';
        private char borderChar;
        public Frame(int x, int widht, int y, int height) : base(x, widht, y, height)
        {
            Deactivate();
        }
        public void SetActive()
        {
            borderChar = activeBorderChar;
        }
        public void Deactivate()
        {
            borderChar = inActiveBorderChar;
        }
        public override void Render()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                if (i == 0 || i == Height - 1)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(borderChar);
                    }
                }
                else
                {
                    Console.Write(borderChar);
                    for (int j = 0; j < Width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(borderChar);
                }
            }
        }
    }
}
