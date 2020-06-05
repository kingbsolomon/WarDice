using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        public int RollDice(int numberOfSides)
        {
            //This method is complete! When called, it will return a random number.
            //You will need to pass in an integer as the parameter to represent the
            //number of sides of the dice being rolled.
            return rand.Next(numberOfSides);
        }

        //Don't change anything above this ^^^^^^^^^^^^


        //Member Methods - All your methods go below here!

        public int ChooseNumberOfSides()
        {
            //This method should prompt the user to enter the number of sides,
            //capture user input and return it after converting it to an integer.
            //This method only needs to be called once in RunGame(), but the returned
            //value should be captured as a variable that will be passed into the
            //RollDice() method each time it's called.
            Console.Write("Please Enter the number of sides: ");
            int numSides = Convert.ToInt32(Console.ReadLine());
            return numSides;
        }

        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {
            if (playerOneRoll > playerTwoRoll)
            {
                playerOneScore++;
            }
            else if (playerOneRoll < playerTwoRoll)
            {
                playerTwoScore++;
            }



        }

        public void DisplayWinner()
        {
           if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playerTwoScore > playerOneScore)
            {
                Console.WriteLine("Player Two Wins!");
            }



        }

        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
        public void RunGame()
        {
            int numSides = ChooseNumberOfSides();
            int player1roll;
            int player2roll;

            while ((playerOneScore < 3) && (playerTwoScore < 3))
            {
                player1roll = RollDice(numSides);
                player2roll = RollDice(numSides);
                Console.WriteLine("Player One Roll:" + player1roll + " Player Two Roll: " + player2roll);
                CompareRolls(player1roll, player2roll);
                Console.WriteLine("Player One Score: " + playerOneScore + " Player Two Score: " + playerTwoScore);
                Console.WriteLine("");
            }

            DisplayWinner();
            Console.ReadLine();




        }
    }
}
