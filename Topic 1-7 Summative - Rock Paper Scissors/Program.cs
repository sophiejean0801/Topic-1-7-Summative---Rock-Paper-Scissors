using System.ComponentModel;

namespace Topic_1_7_Summative___Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            bool done = false;
            string guess, challengeAnswer;
            int answer, playerScore = 3, computerScore = 3, ties = 0, rock = 0, paper = 1, scissors = 2;
            Random random = new Random();
            Console.WriteLine("In the final battle against the computer king and his minions, he challenges you to a simple game of rock paper scissors. This game will decide the fate of the world. Would you like to continue?");
            Console.ReadLine();
            if (challengeAnswer == "no")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Coward. You did not accept his challenge and you let the computers win.");
                done = true;
            }
            if (challengeAnswer == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You accepted his challenge and the weight of the world is on your shoulders! In order to win, you mus obtain points to deplete the computer king's points. HOWEVER if the computer king wins a round your points are depleted instead of his. Deplete his points to 0 to win. Good luck.");
                done = false;
            }
            if ("yes" != challengeAnswer && "no" != challengeAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have failed to make a decision at such a crucial moment. The computer king has taken over the world.");
                done = true;
            }
            while (!done)
            {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Enter rock, paper, or scissors: ");
                guess = Console.ReadLine();
                answer = random.Next(0, 3);
                if (answer == 0 && guess == "rock")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 0 && guess == "paper")
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                    computerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 0 && guess == "scissors")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 1 && guess == "rock")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 1 && guess == "paper")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 1 && guess == "scissors")
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                    computerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 2 && guess == "rock")
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                    computerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 2 && guess == "paper")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 2 && guess == "scissors")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                    Console.WriteLine("Player Score: " + playerScore);
                    Console.WriteLine("Computer Score: " + computerScore);
                }
                if (answer == 0 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? You lose a point.");
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                }
                if (answer == 1 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? You lose a point.");
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                }
                if (answer == 2 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? You lose a point.");
                    playerScore--;
                    Console.WriteLine("Player Score: " + playerScore);
                }
                if (computerScore == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You beat the computer king and his minions and prevented them from taking over the world! That's a thing you did!");
                    done = true;
                }
                if (playerScore == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost to the computer king and now they have taken over the world!!");
                    done = true;
                }
                Console.WriteLine("Would you like to continue?");
                if (Console.ReadLine() == "no")
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Coward. You have chosen to let the computer king take over the world.");
                    done = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have chosen to continue the fight against the computer king!");
                    done = false;
                }





            }    
        }
    }
}
