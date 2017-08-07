using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        public Human(string Name)
        {
            this.Name = Name;
        }

        //method for a human to make a choice
        public void MakeChoice()
        {
            Console.WriteLine();
            Choice = Console.ReadLine();
        }
    }
}
