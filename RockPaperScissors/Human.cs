using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        public Human(string Name)
        {
            this.Name = Name;
        }
        //public void MakeChoice()
        //{
        //    Console.WriteLine("Pick Rock, Paper, Scissors, Lizard, Spock");
        //    Choice = Console.ReadLine();
        //}
    }
}
