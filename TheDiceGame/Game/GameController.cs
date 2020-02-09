using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;
using TheDiceGame.GUI;

namespace TheDiceGame.Game
{
    class GameController
    {
        private GameWindow myGame;
        private MenuController menuController;
        private GameOverMenu gameOverMenu;
        int roundsCount = 1;

        public GameController(int roundsCount, MenuController menuController)
        {
            this.menuController = menuController;
            this.roundsCount = roundsCount;
        }
        public void InitGame()
        {
            myGame = new GameWindow(0, 120, 0, 30, '+', 0);
            for (int i = 0; i < menuController.playerSelectionMenu.NumberOfPlayers; i++)
            {
                myGame.AddPlayer(new Player("Player" + (i + 1)));
            }
        }

        public void StartGame()
        {
            for (int i = 0; i < roundsCount; i++)
            {
                myGame.MoveToNextRound();
                myGame.Render();
                foreach (Player player in myGame.players)
                {
                    myGame.RollDice(player);

                    myGame.Render();
                    System.Threading.Thread.Sleep(2500);
                }

                if (i == (roundsCount - 1))
                {
                    if (myGame.DetermineWinner()) //If winner can be determined after original number of rounds
                    {
                        gameOverMenu = new GameOverMenu(0, 120, 0, 30, 'o', new List<string>() {
                            $"The winner is: {myGame.Winner.Name} with {myGame.Winner.Score} points.",
                            "","","",
                            "R - Replay     M- Go to menu     Q - Quit"
                            });
                        menuController.ActivateGameOverMenu(gameOverMenu);
                    }
                    else
                    {
                        myGame.NarrowDownToLeaders();
                        roundsCount++; //create additional round
                    }
                }
            };
        }
    }
}
