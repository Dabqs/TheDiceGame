using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.Game;
using TheDiceGame.GameSubjects;

namespace TheDiceGame.GUI
{
    class GameWindow : Window
    {
        private ScoreBoard scoreBoard;
        public Player Winner { get; private set; }
        private TextLine title = new TextLine(40, 50, 10, String.Empty);
        private int roundNumber = 1;
        public List<Player> players { get; private set; } = new List<Player>();
        private DiceRound diceRound;
        public GameWindow(int x, int widht, int y, int height, char borderChar, int roundNumber) : base(x, widht, y, height, borderChar)
        {
            this.roundNumber = roundNumber;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RollDice(Player player)
        {
            diceRound = new DiceRound(player);
            diceRound.Dice();
            title = new TextLine(40, 50, 10, $"{player.Name} has rolled {diceRound.DiceResult}.");
            scoreBoard = new ScoreBoard(5, 60, 3, 25, players, roundNumber);
        }

        public void MoveToNextRound()
        {
            roundNumber++;
            scoreBoard = new ScoreBoard(5, 60, 3, 25, players, roundNumber);
        }
        public int GetBestScore()
        {
            return (from player in players
                    select player.Score).Max();
        }
        private void SetWinner(int bestScore)
        {
            Winner = (from player in players
                      where player.Score == bestScore
                      select player).FirstOrDefault();
        }
        public bool DetermineWinner()
        {
            int bestScore = GetBestScore();
            int numberOfPlayersThatSharesBestScore = players.Where(p => p.Score == bestScore).Count();

            if (numberOfPlayersThatSharesBestScore > 1)
            {
                return false;
            }
            else
            {
                SetWinner(bestScore);
                return true;
            }
        }
        public void NarrowDownToLeaders()
        {
            players = (from player in players
                    where player.Score == GetBestScore()
                    select player).ToList();
        }
        public override void Render()
        {
            base.Render();
            scoreBoard.Render();
            title.Render();
            Console.SetCursorPosition(0, 0);
        }
    }
}
