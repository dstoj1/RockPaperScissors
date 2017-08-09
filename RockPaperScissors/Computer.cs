using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {

        public Computer(string Name)
        {
            this.Name = Name;
            
        }
        public override void MakeChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            string[] choices = new string[] {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
            Choice = choices[randomNumber].ToLower(); 
        }
       
    }
}
