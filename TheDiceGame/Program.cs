using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.Game;
using TheDiceGame.GameSubjects;
using TheDiceGame.GUI;

namespace TheDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController gameMenu = new MenuController();
            gameMenu.ShowMainMenu();
        }
    }
}
