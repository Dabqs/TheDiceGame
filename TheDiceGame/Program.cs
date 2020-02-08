using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;
using TheDiceGame.GUI;

namespace TheDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu(0, 120, 0, 30, '@');
            mainMenu.Render();
           // Window wind = new Window(0, 120, 0, 30,'@');
           // wind.Render();
           //
           // Button btn = new Button(5, 10, 5, 5, "Button");
           // btn.Render();
           // Console.SetCursorPosition(0, 0);
           // Console.ReadLine();
           // btn.SetActive();
           // btn.Render();

            //  Dice dice = new Dice();
            //      Console.WriteLine(dice.Roll());   
            // Player p1 = new Player("Mantas");
            // p1.RollDice();
            // p1.RollDice();
            // Console.WriteLine(p1.Score);
            // Console.WriteLine(p1.turnsCount);

            //TextBlock txtBlock = new TextBlock(10, 40, 5, 60,
            //    new List<string>()
            //    {
            //        "This is the game",
            //        "That was created by mister MD.",
            //        "Enjoy yourself"
            //    });
            //txtBlock.Render();

        }
    }
}
