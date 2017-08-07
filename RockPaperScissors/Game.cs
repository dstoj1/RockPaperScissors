using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        
        public void GetPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            //if 1, then instantiate Human and Computer
            //if 2, then instantiate Human and Human
        }

        public Game()
        {

        }

        public void CompareChoices()
        {
            
            switch (//Human.Choice)
            {
                case "Rock":

                    switch (//Computer.Choice or Human.Choice)
                    {
                        case "Rock":
                            Console.WriteLine("Tie!");
                            break;
                        case "Paper":
                            Console.WriteLine("You Win");
                            break;
                        case "Scissors":
                            Console.WriteLine("You Lose");
                            break:
                        case "Lizard";
                            Console.WriteLine("You Lose");
                            break:
                        case "Spock":
                            Console.WriteLine("You Win");
                            break;
                        default;
                            break;
                        
                    }
            }
        }
    }
}
