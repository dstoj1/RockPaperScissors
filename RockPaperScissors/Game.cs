using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        Player PlayerOne;
        Player PlayerTwo;

        public void DisplayRules()
        {
            Console.WriteLine("Best 2 out of 3 wins the game!");
        }
        public void GetPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            PlayerOne.CompareChoices(PlayerTwo.Choice);
            if (numberOfPlayers == 1)
            {
                string Name = "";
                PlayerOne = new Human(Name);
                PlayerTwo = new Computer(Name);
                PlayerOne.Name = GetPlayerName();
                PlayerTwo.Name = GetPlayerName();
            }
            else if (numberOfPlayers == 2)
            {
                string Name = "";
                PlayerOne = new Human(Name);
                PlayerTwo = new Human(Name);
                PlayerOne.Name = GetPlayerName();
                PlayerTwo.Name = GetPlayerName();
            }
            else
            {
                Console.WriteLine("Please choose 1 or 2 Players");
                GetPlayers();


            }
        }
        public void CompareChoices(string OtherPlayerChoice)
        {
            switch (PlayerOne.Choice)
            {
                case "Rock":

                    switch (OtherPlayerChoice)
                    {
                        case "Rock":
                            Console.WriteLine("Tie!");
                            break;
                        case "Paper":
                            Console.WriteLine("You Win");
                            break;
                        case "Scissors":
                            Console.WriteLine("You Lose");
                            break;
                        case "Lizard":
                            Console.WriteLine("You Lose");
                            break;
                        case "Spock":
                            Console.WriteLine("You Win");
                            break;
                        default:
                            break;
                    }
                    break;
                case "Paper":

                    switch (OtherPlayerChoice)
                    {
                        case "Rock":
                            Console.WriteLine($"{PlayerTwo} Wins!");
                            break;
                        case "Paper":
                            Console.WriteLine($"{PlayerTwo} ties with {PlayerTwo}");
                            break;
                        case "Scissors":
                            Console.WriteLine($"{PlayerOne} Wins");
                            break;
                        case "Lizard":
                            Console.WriteLine($"{PlayerTwo} Wins");
                            break;
                        case "Spock":
                            Console.WriteLine($"{PlayerTwo} Wins");
                            break;
                        default:
                            break;
                    }
                    break;

                case "Scissors":

                    switch (OtherPlayerChoice)
                    {
                        case "Rock":
                            Console.WriteLine($"{PlayerTwo} Wins!");
                            break;
                        case "Paper":
                            Console.WriteLine($"{PlayerOne}");
                            break;
                        case "Scissors":
                            Console.WriteLine($"{PlayerOne} ties with {PlayerTwo}");
                            break;
                        case "Lizard":
                            Console.WriteLine($"{PlayerOne} Wins");
                            break;
                        case "Spock":
                            Console.WriteLine($"{PlayerTwo} Wins");
                            break;
                        default:
                            break;
                    }
                    break;

                case "Lizard":

                    switch (OtherPlayerChoice)
                    {
                        case "Rock":
                            Console.WriteLine($"{PlayerTwo} Wins!");
                            break;
                        case "Paper":
                            Console.WriteLine($"{PlayerOne} Wins!");
                            break;
                        case "Scissors":
                            Console.WriteLine($"{PlayerTwo} Wins!");
                            break;
                        case "Lizard":
                            Console.WriteLine($"{PlayerTwo} ties with {PlayerOne}");
                            break;
                        case "Spock":
                            Console.WriteLine($"{PlayerOne} Wins");
                            break;
                        default:
                            break;
                    }
                    break;

                case "Spock":

                    switch (OtherPlayerChoice)
                    {
                        case "Rock":
                            Console.WriteLine($"{PlayerOne} Wins!");
                            break;
                        case "Paper":
                            Console.WriteLine($"{PlayerOne} Wins!");
                            break;
                        case "Scissors":
                            Console.WriteLine($"{PlayerOne} Wins");
                            break;
                        case "Lizard":
                            Console.WriteLine($"{PlayerTwo} Wins");
                            break;
                        case "Spock":
                            Console.WriteLine($"{PlayerOne} ties with {PlayerTwo}");
                            break;
                        default:
                            break;
                    }
                    break;
            }
        }
    }
}
