﻿using System.ComponentModel;

namespace Topic_1_7_Summative___Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            bool done = false;
            string guess, challengeAnswer;
            int answer, playerWallet = 100, computerWallet = 100, ties = 0, rock = 0, paper = 1, scissors = 2;
            Random random = new Random();
            Console.WriteLine("In the final battle against the computer king and his minions, he challenges you to a simple game of rock paper scissors. This game will decide the fate of the world. Would you like to continue?");
            challengeAnswer = Console.ReadLine().ToLower();
            if (challengeAnswer == "no")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Coward. You did not accept his challenge and you let the computers win.");
                done = true;
            }
            else if (challengeAnswer == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You accepted his challenge and the weight of the world is on your shoulders!"); 
                done = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have failed to make a decision at such a crucial moment. The computer king has taken over the world.");
                done = true;
            }
            while (!done)
            {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You have " + playerWallet + " dollars in your wallet and the computer king has " + computerWallet + " dollars in his wallet.");
                Console.WriteLine("How much would you like to bet?");
                int bet = Convert.ToInt32(Console.ReadLine());
                if (bet < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You cannot bet a negative amount of money. Are you stupid?");
                    done = true;
                }
                else if (bet > playerWallet)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Don't be stupid, you cannot bet more money than you have in your wallet.");
                    done = true;
                }
                else if (bet == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You cannot bet 0 dollars.");
                    done = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have chosen to bet " + bet + " dollars.");
                    Console.WriteLine("Enter your guess: rock, paper, or scissors.");
                    done = false;
                }
                guess = Console.ReadLine().ToLower();
                answer = random.Next(3);
                if (answer == rock && guess == "rock")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;
                    
                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                else if (answer == rock && guess == "paper")
                {
                    Console.WriteLine("You win!");
                    playerWallet = playerWallet + bet;
                    computerWallet = computerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                else if (answer == rock && guess == "scissors")
                {
                    Console.WriteLine("You lose!");
                    computerWallet = computerWallet + bet;
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                if (answer == paper && guess == "rock")
                {
                    Console.WriteLine("You lose!");
                    computerWallet = computerWallet + bet;
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                else if (answer == paper && guess == "paper")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                else if (answer == paper && guess == "scissors")
                {
                    Console.WriteLine("You win!");
                    playerWallet = playerWallet + bet;
                    computerWallet = computerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                if (answer == scissors && guess == "rock")
                {
                    Console.WriteLine("You win!");
                    playerWallet = playerWallet + bet;
                    computerWallet = computerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                else if (answer == scissors && guess == "paper")
                {
                    Console.WriteLine("You lose!");
                    computerWallet = computerWallet + bet;
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                if (answer == 2 && guess == "scissors")
                {
                    Console.WriteLine("It's a tie!");
                    ties++;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                    Console.WriteLine("Computer Wallet: " + computerWallet);
                }
                if (answer == 0 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? Say goodbye to your money.");
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                }
                if (answer == 1 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? Say goodbye to your money.");
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                }
                if (answer == 2 && guess != "rock" && guess != "paper" && guess != "scissors")
                {
                    Console.WriteLine("You seriously messed up at such a crucial moment? You lose a point.");
                    playerWallet = playerWallet - bet;

                    Console.WriteLine("Player Wallet: " + playerWallet);
                }
                if (computerWallet == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You beat the computer king and his minions and prevented them from taking over the world! That's a thing you did!");
                    done = true;
                    break;
                }
                if (playerWallet == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost to the computer king and his minions and now they have taken over the world!!");
                    done = true;
                    break;
                }
                Console.WriteLine("Would you like to continue?");
                if (Console.ReadLine() == "no")
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Coward. You have chosen to let the computer king take over the world.");
                    
                    Console.WriteLine("Player Wallet: " + playerWallet);
                    
                    Console.WriteLine("You died.");
                    done = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    Console.WriteLine("You have chosen to continue the fight against the computer king!");
                    
                    Console.WriteLine("Player Wallet: " + playerWallet);
                    done = false;
                }





            }    
        }
    }
}
