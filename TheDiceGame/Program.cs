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
            //MenuController menuControler = new MenuController();
            //menuControler.ShowMainMenu();
          GameWindow gWindow = new GameWindow(0, 120, 0, 30, '+', new List<Player>()
         {
             new Player("Robertas"),
             new Player("Mantas"),
             new Player("Albertas"),
             new Player("Pranciskus"),
         });
          gWindow.Render();

        }
    }
}
