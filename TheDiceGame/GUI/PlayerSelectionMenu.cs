using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiceGame.GUI
{
    class PlayerSelectionMenu : Menu
    {
        private List<Button> menuButtons = new List<Button>();
        private int buttonX = 65;
        private int buttonY = 4;
        private int buttonWidth = 8;
        private int buttonHeight = 5;

        public PlayerSelectionMenu(int x, int widht, int y, int height, char borderChar, List<string> title) : base(x, widht, y, height, borderChar, title)
        {
            
            for (int i = 0; i < 6; i++) //build buttons
            {
                if (buttonX == 65)
                {
                    buttonX = 50;
                    buttonY = buttonY + 6;
                }
                else
                {
                    buttonX = 65;
                }
                menuButtons.Add(new Button(buttonX,buttonWidth,buttonY,buttonHeight,"P" + (i+2)));
            }

        }

        public override void Render()
        {
            base.Render();
            foreach (Button button in menuButtons)
            {
                button.Render();
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
