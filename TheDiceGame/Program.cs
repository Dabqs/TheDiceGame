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
            List<Player> players = new List<Player>()
         {
             new Player("Robertas"),
             new Player("Mantas"),
             new Player("Albertas"),
             new Player("Pranciskus") };
            //MenuController menuControler = new MenuController();
            //menuControler.ShowMainMenu();
          GameWindow gWindow = new GameWindow(0, 120, 0, 30, '+');
            gWindow.AddPlayer(new Player("Robertas"));
            gWindow.AddPlayer(new Player("Mantas"));

            gWindow.RollDice(gWindow.players[0]);
            gWindow.Render();
            Console.ReadLine();
            gWindow.RollDice(gWindow.players[1]);
            gWindow.Render();
            Console.ReadLine();
            gWindow.RollDice(gWindow.players[0]);
            gWindow.Render();
            Console.ReadLine();
        }
    }
}
