using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GUI;

namespace TheDiceGame.Game
{
    class MenuController
    {
        #region InitObjects
        private int currentActiveButton;
        private int targetId;
        private GameController game;
        private MainMenu mainMenu = new MainMenu(0, 120, 0, 30, '@', new List<string>()
            {
                "The dice game",
                "Made by Mantas Dapkus",
                "Vilnius Coding School",
                "","","",
                "P - Play     Q-Quit"
            });

        public PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu(0, 120, 0, 30, 'o', new List<string>()
            {
                "Select number of players",
                "(Navigate with arrow keys)",
                "Press 'Esc' to go back"
            });

        public  DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu(0, 120, 0, 30, 'o', new List<string>()
            {
                "Choose number of dices (use +/-)",
                "Press Enter to continue"
            });
        #endregion
        public void ShowMainMenu()
        {
            mainMenu.Render();
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.P)
                {
                    ActivatePlayerSelectionMenu();
                }
                else if (pressedKey.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
            }
        }
        public void ActivatePlayerSelectionMenu()
        {
            do
            {
                playerSelectionMenu.Render();
                currentActiveButton = playerSelectionMenu.GetActiveButtonIndex();
            waitForKeyPress: //so that console doesn't render if not needed
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        ShowMainMenu();
                        break;
                    case ConsoleKey.Enter:
                        playerSelectionMenu.SetNumberOfPlayers();
                        ActivateDiceSelectionMenu();

                        break;
                    case ConsoleKey.LeftArrow:
                        targetId = currentActiveButton - 1;
                        playerSelectionMenu.ChangeActiveButton(targetId);
                        break;
                    case ConsoleKey.RightArrow:
                        targetId = currentActiveButton + 1;
                        playerSelectionMenu.ChangeActiveButton(targetId);
                        break;
                    case ConsoleKey.UpArrow:
                        targetId = currentActiveButton - 2;
                        playerSelectionMenu.ChangeActiveButton(targetId);
                        break;
                    case ConsoleKey.DownArrow:
                        targetId = currentActiveButton + 2;
                        playerSelectionMenu.ChangeActiveButton(targetId);
                        break;
                    default:
                        goto waitForKeyPress;
                }

            } while (true);

        }

        public void ActivateDiceSelectionMenu()
        {
            do
            {
                diceSelectionMenu.Render();
                waitForKeyPress: //so that console doesn't render if not needed
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.OemPlus:
                        diceSelectionMenu.IncreaseDicesCount();
                        break;
                    case ConsoleKey.OemMinus:
                        diceSelectionMenu.ReduceDicesCount();
                        break;
                    case ConsoleKey.Enter:
                        game = new GameController(diceSelectionMenu.DiceCount, this);
                        game.InitGame();
                        game.StartGame();
                        break;
                    case ConsoleKey.Escape:
                        ActivatePlayerSelectionMenu();
                        break;
                    default:
                        goto waitForKeyPress;
                }
            } while (true);

        }
        public void ActivateGameOverMenu(GameOverMenu gameOverMenu)
        {
            do
            {
                gameOverMenu.Render();
            waitForKeyPress: //so that console doesn't render if not needed
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.R:
                        game = new GameController(diceSelectionMenu.DiceCount, this);
                        game.InitGame();
                        game.StartGame();
                        break;
                    case ConsoleKey.M:
                        ShowMainMenu();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    default:
                        goto waitForKeyPress;
                }
            } while (true);
        }
    }
}
