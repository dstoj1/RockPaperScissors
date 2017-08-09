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
            // CompareChoices(PlayerTwo.Choice);
            if (numberOfPlayers == 1)
            {
                string Name = "";
                PlayerOne = new Human(Name);
                PlayerTwo = new Computer("Computer");
                PlayerOne.Name = GetPlayerName();
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
        public void CompareChoices(string OtherPlayerChoice)
        {
            switch (PlayerOne.Choice)
            {
                case "rock":

                    switch (OtherPlayerChoice)
                    {
                        case "rock":
                            Console.WriteLine($"{PlayerOne.Name} ties with {PlayerTwo.Name}");
                            break;
                        case "paper":
                            Console.WriteLine($"{PlayerOne.Name} Wins!");
                            PlayerOne.IncrementScore();
                            break;
                        case "scissors":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        case "lizard":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        case "spock":
                            Console.WriteLine($"{PlayerOne.Name} Wins!");
                            PlayerOne.IncrementScore();
                            break;
                        default:
                            break;
                    }
                    break;
                case "paper":

                    switch (OtherPlayerChoice)
                    {
                        case "rock":
                            Console.WriteLine($"{PlayerOne.Name} Wins!");
                            PlayerOne.IncrementScore();
                            break;
                        case "paper":
                            Console.WriteLine($"{PlayerOne.Name} ties with {PlayerTwo.Name}");
                            break;
                        case "scissors":
                            Console.WriteLine($"{PlayerOne.Name} Wins");
                            PlayerOne.IncrementScore();
                            break;
                        case "lizard":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        case "spock":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        default:
                            break;
                    }
                    break;

                case "scissors":

                    switch (OtherPlayerChoice)
                    {
                        case "rock":
                            Console.WriteLine($"{PlayerTwo.Name} Wins!");
                            PlayerTwo.IncrementScore();
                            break;
                        case "paper":
                            Console.WriteLine($"{PlayerOne.Name}");
                            PlayerOne.IncrementScore();
                            break;
                        case "scissors":
                            Console.WriteLine($"{PlayerOne.Name} ties with {PlayerTwo.Name}");
                            break;
                        case "lizard":
                            Console.WriteLine($"{PlayerOne.Name} Wins");
                            PlayerOne.IncrementScore();
                            break;
                        case "spock":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        default:
                            break;
                    }
                    break;

                case "lizard":

                    switch (OtherPlayerChoice)
                    {
                        case "rock":
                            Console.WriteLine($"{PlayerTwo.Name} Wins!");
                            PlayerTwo.IncrementScore();
                            break;
                        case "paper":
                            Console.WriteLine($"{PlayerOne.Name} Wins!");
                            PlayerOne.IncrementScore();
                            break;
                        case "scissors":
                            Console.WriteLine($"{PlayerTwo.Name} Wins!");
                            PlayerTwo.IncrementScore();
                            break;
                        case "lizard":
                            Console.WriteLine($"{PlayerTwo.Name} ties with {PlayerOne.Name}");
                            break;
                        case "spock":
                            Console.WriteLine($"{PlayerOne.Name} Wins");
                            PlayerOne.IncrementScore();
                            break;
                        default:
                            break;
                    }
                    break;

                case "spock":

                    switch (OtherPlayerChoice)
                    {
                        case "rock":
                            Console.WriteLine($"{PlayerTwo.Name} Wins!");
                            PlayerTwo.IncrementScore();
                            break;
                        case "paper":
                            Console.WriteLine($"{PlayerOne.Name} Wins!");
                            PlayerOne.IncrementScore();
                            break;
                        case "scissors":
                            Console.WriteLine($"{PlayerOne.Name} Wins");
                            PlayerOne.IncrementScore();
                            break;
                        case "lizard":
                            Console.WriteLine($"{PlayerTwo.Name} Wins");
                            PlayerTwo.IncrementScore();
                            break;
                        case "spock":
                            Console.WriteLine($"{PlayerOne.Name} ties with {PlayerTwo.Name}");
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
                Console.WriteLine($"{PlayerOne.Name} Wins the GAME!!!!!");
            }
            else if(PlayerTwo.RoundScore == 2)
            {
                Console.WriteLine($"{PlayerTwo.Name} Wins the GAME!!!!");
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
                Console.ReadLine();
            }
        }
        public void RunGame()
        {
            DisplayRules();
            GetPlayers();
          while(PlayerOne.RoundScore < 2 && PlayerTwo.RoundScore < 2)
            {
                PlayerOne.MakeChoice();
                PlayerTwo.MakeChoice();
                CompareChoices(PlayerTwo.Choice);
                Winner();
            }
            PlayAgain();
            Environment.Exit(0);
        }
    }
}