using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class MainMenu : Window
    {
        private TextLine playTextline;
        private TextLine quitTextLine;
        private TextBlock title;



        public MainMenu(int x, int widht, int y, int height, char borderChar) : base(x, widht, y, height, borderChar)
        {
            playTextline = new TextLine((Width /2) -18,8,Height / 2,"P - Play");
            quitTextLine = new TextLine((Width /2) +10,8,Height / 2,"Q - Quit");
            title = new TextBlock(10,100,8,new List<string>()
            {
                "Dice game",
                "Made by Mantas Dapkus",
                "Made in Vilnius Coding School"
            }) ;
        }

        public override void Render()
        {
            base.Render();
            title.Render();
            playTextline.Render();
            quitTextLine.Render();
            Console.SetCursorPosition(0,0);
        }

    }
}
