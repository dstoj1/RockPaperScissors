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
        string UserInput;

        public void DisplayRules()
        {
            Console.WriteLine("Best 2 out of 3 wins the game!");
        }
        public void GetPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            CompareChoices(PlayerTwo.Choice);
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
        public string GetPlayerName()
        {
            Console.WriteLine("Please enter name");
            string PlayerName = Console.ReadLine();
            return PlayerName;
        }
        public void FindWinner()
        {
            if(PlayerOne.RoundScore == 2)
            {
                Console.WriteLine($"{PlayerOne.Name} wins the game!");
            }
            else if(PlayerTwo.RoundScore == 2)
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the game!");
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
        public void Winner()
        {
            if(PlayerOne.RoundScore == 2)
            {
                Console.WriteLine($"{PlayerOne} Wins!");
            }
            else if(PlayerTwo.RoundScore == 2)
            {
                Console.WriteLine($"{PlayerTwo} Wins!");
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            UserInput = Console.ReadLine();
            if(UserInput.ToLower() == "yes")
            {
                RunGame();
            }
            else 
            {
                Console.WriteLine("Thank You for playing");
                Environment.Exit(0);
            }
        }
        public void RunGame()
        {
            DisplayRules();
            GetPlayers();
          while(PlayerOne.RoundScore < 2 && PlayerTwo.RoundScore < 2)
            {

            }
        }
    }
}