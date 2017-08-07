using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {

        public Computer(string Name)
        {
            this.Name = Name;
            
        }
        Random random = new Random();
        int randomNumber = Random.next(1, 6);
       
    }
}
