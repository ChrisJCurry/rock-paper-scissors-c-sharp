using System;
namespace rock_paper_scissors.Models
{
    public class RockPaperScissors
    {
        public RockPaperScissors(string userInput)
        {
            UserInput = userInput;
            CompInput = getCompInput();
        }

        public int getCompInput()
        {
            Random rnd = new Random();
            int rndResult = rnd.Next(0, 3);
            return rndResult;
        }

        public int getWinner()
        {
            int userIntInput = -5;
            if (UserInput == "rock")
            {
                userIntInput = 0;
            }
            else if (UserInput == "paper")
            {
                userIntInput = 1;
            }
            else if (UserInput == "scissors")
            {
                userIntInput = 2;
            }
            if (userIntInput == CompInput)
            {
                return 0;
            }
            else if ((userIntInput + 1) % 3 == CompInput)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }

        public string UserInput
        {
            get;
            set;
        }

        public int CompInput
        {
            get;
            set;
        }
    }
}