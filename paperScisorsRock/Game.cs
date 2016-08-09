using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paperScisorsRock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        string one = "scissors";
        string two = "rock";
        string three = "paper";

        public Game()
        {
            Console.WriteLine("PLAYER ONE, what is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("PLAYER TWO, what is your name?");
            this.playerTwo = new Player(Console.ReadLine());
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to Scissors, Paper, Rock!\n choose what you want {0}", playerOne.getName());
            playerOne.setOption(Console.ReadLine());
            Console.WriteLine("Welcome to Paper, Rock, Scissors!\n Choose your fate {0}", playerTwo.getName());
            playerTwo.setOption(Console.ReadLine());
            choice();
        }
        public void choice()
        {
            if(playerOne.getOption() == one && playerTwo.getOption() == two)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!", playerOne.getOption(), one, playerTwo.getOption(), two);
             } else if(playerOne.getOption() == two && playerTwo.getOption() == one)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!", playerOne.getOption(), two, playerTwo.getOption(), one);
            } else if(playerOne.getOption() == one && playerTwo.getOption() == three)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!", playerOne.getOption(), one, playerTwo.getOption(), three);
            } else if(playerOne.getOption() == three && playerTwo.getOption() == one)
            {
                Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!", playerOne.getOption(), three, playerTwo.getOption(), one);
            } else
                Console.WriteLine("It's a tie!");
            }
        }
    }

