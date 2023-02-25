using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGame.Entities
{
    internal class Score
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public Score() { }

        public Score(int wins, int losses, int ties)
        {
            Wins = wins;
            Losses = losses;
            Ties = ties;
        }

        public void AddWins()
        {
            Wins++;
        }
        public void AddLosses()
        {
            Losses++;
        }
        public void AddTies()
        {
            Ties++;
        }
    }
}
