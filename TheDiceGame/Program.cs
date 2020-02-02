using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDiceGame.GameSubjects;

namespace TheDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Dice dice = new Dice();
            //      Console.WriteLine(dice.Roll());   
            Player p1 = new Player("Mantas");
            p1.RollDice();
            p1.RollDice();
            Console.WriteLine(p1.Score);
            Console.WriteLine(p1.turnsCount);

        }
    }
}
