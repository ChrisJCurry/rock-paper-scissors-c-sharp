using System;
using System.Threading;
using rock_paper_scissors.Models;


namespace rock_paper_scissors
{
    class Program
    {

        static int compWins = 0;
        static int userWins = 0;
        static int ties = 0;
        static bool running = true;


        static void Main(string[] args)
        {
            Console.Clear();
            while (running)
            {

                //randomBeeps();
                //heartBeat();
                //Console.Beep(2500, 500);
                Console.Clear();
                string userInput = getUserInput();
                RockPaperScissors RPS = new RockPaperScissors(userInput);
                int res = RPS.getWinner();
                if (res == 1)
                {
                    Console.Beep(2500, 200);
                    userWins++;
                    Console.WriteLine("You win! Your wins: " + userWins);
                }

                else if (res == -1)
                {
                    Console.Beep(750, 200);
                    compWins++;
                    Console.WriteLine("You lose! Computer wins: " + compWins);
                }
                else if (res == 0)
                {
                    Console.Beep(1250, 200);
                    ties++;
                    Console.WriteLine("It's a tie! Your ties: " + ties);
                }
                else
                {
                    Console.WriteLine("ERROR. CLOSING");
                    return;
                }
                Console.WriteLine("\n\nWould you like to play again? (Y/N)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "no" || playAgain[0] == 'n')
                {
                    running = false;
                }
            }

        }

        static void randomBeeps()
        {
            while (true)
            {
                Random rnd = new Random();
                int freq = rnd.Next(450, 2000);
                int duration = rnd.Next(150, 300);
                int sleepTime = rnd.Next(100, 200);

                Console.Beep(freq, duration);
                Thread.Sleep(sleepTime);
            }
        }

        static void heartBeat()
        {
            int duration = 250;
            while (true)
            {
                //Console.Beep(2500, duration);
                Thread.Sleep(10);
                Random rnd = new Random();
                int res = rnd.Next(0, 15);
                switch (res)
                {
                    case 0:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("He's dead, Jim");
                        break;
                    case 4:
                    case 13:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        break;
                    case 1:
                    case 6:
                    case 14:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        break;
                    case 2:
                    case 5:
                    case 9:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        break;
                }
                Console.WriteLine(res);
                if (res == 0)
                {
                    duration = int.MaxValue;
                }
            }

        }

        static string getUserInput()
        {

            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine("Rock, Paper, or Scissors?");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "rock" || userInput.ToLower() == "paper" || userInput.ToLower() == "scissors")
                {
                    invalidInput = false;
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice.");
                }
            }
            Console.Beep(100, 100);
            return "-1";
        }

        static void getWinner(string userInput, int compInput)
        {
            for (int i = 0; i < compInput; i++)
            {

            }
        }

        static void getWinner(string userInput, string compInput)
        {
            if (userInput == "rock" && compInput == "paper")
            {
                compWins++;
                Console.WriteLine($"You lose! Your wins: {userWins}, Computer wins: {compWins}");
            }
            else if (userInput == "paper" && compInput == "paper")
            {
                ties++;
                Console.WriteLine($"Tie! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "scissors" && compInput == "paper")
            {
                userWins++;
                Console.WriteLine($"You Win! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "rock" && compInput == "rock")
            {
                ties++;
                Console.WriteLine($"Tie! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "paper" && compInput == "rock")
            {
                userWins++;
                Console.WriteLine($"You Win! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "scissors" && compInput == "rock")
            {
                compWins++;
                Console.WriteLine($"You lose! Your wins: {userWins}, Computer wins: {compWins}");
            }
            else if (userInput == "rock" && compInput == "scissors")
            {
                userWins++;
                Console.WriteLine($"You Win! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "paper" && compInput == "scissors")
            {
                compWins++;
                Console.WriteLine($"You lose! Your wins: {userWins}, Computer wins: {compWins}, Ties: {ties}");
            }
            else if (userInput == "scissors" && compInput == "scissors")
            {
                ties++;
                Console.WriteLine($"Tie! Your wins: {userWins}, Computer wins: {compWins}");
            }
        }
    }
}
