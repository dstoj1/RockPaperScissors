using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string Name;
        public string Choice;
        public int Score;
        public int RoundScore;

        public Player()
        {

        }
        public void IncrementScore()
        {
            RoundScore++;
        }
        public virtual void MakeChoice()
        {
            Console.WriteLine($"{Name.ToUpper()} Please Pick, Rock, Paper, Scissors, Lizard, Spock");
            Choice = Console.ReadLine().ToLower(); 
        }
    }
}
