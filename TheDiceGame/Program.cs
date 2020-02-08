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
            MainMenu mainMenu = new MainMenu(0, 120, 0, 30, '@',new List<string>()
            {
                "The dice game",
                "Made by Mantas Dapkus",
                "Vilnius Coding School",
                "","","",
                "P - Play     Q-Quit"
            });
            mainMenu.Render();
            Console.ReadLine();
            PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu(0, 120, 0, 30, 'o',new List<string>()
            {
                "Select number of players",
                "(Navigate with arrow keys)",
                "Press 'Esc' to go back"
            });
            playerSelectionMenu.Render();
            Console.ReadLine();
            GameOverMenu gameOverMenu  = new GameOverMenu(0, 120, 0, 30, 'o', new List<string>()
            {
                "Game over",
                "{Player} won",
                "Scoreboard...",
                "",
                "R - Replay game     M - Go to menu      Q - Quit"
            });
            gameOverMenu.Render();



            Console.ReadLine();
            DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu(0, 120, 0, 30, 'o', new List<string>()
            {
                "Choose number of dices (use +/-)",
                "Press Enter to continue"
            });
            diceSelectionMenu.Render();

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
