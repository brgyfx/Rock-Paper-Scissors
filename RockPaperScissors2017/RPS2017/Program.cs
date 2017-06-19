using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RockPaperScissors
{
    class Program
    {
        static int meme;
        static string memeinput;

        static void Creditslol()
        {
            Console.WriteLine(@"Written by Joel F
only 14 lol pls dont judge my shitty c# code :p");
            Console.WriteLine("Enter any key to exit lol");
        }

        static void RockPaperScissors()
        {
            string botchoose = string.Empty;
            Console.WriteLine("Enter Paper to use Paper, Rock to use Rock and Scissors to use Scissors");
            Console.WriteLine("Are you ready?");
            string response = Console.ReadLine();
            if (response.ToLower().Equals("yes"))
            {
                Console.WriteLine("The game will start in three seconds!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Console.WriteLine();
                Console.WriteLine("The game has begun!");
                bool runNewLoop = true;
                int score = 0;
                int botscore = 0;
                int count = 3;
                while (count > 0 && runNewLoop == true)
                {
                    Random rnd = new Random();
                    int numgen = rnd.Next(1, 4);
                    if (numgen == 1)
                    {
                        botchoose = "Paper";
                    }
                    else if (numgen == 2)
                    {
                        botchoose = "Rock";
                    }
                    else if (numgen == 3)
                    {
                        botchoose = "Scissors";
                    }
                    Console.WriteLine("Enter Rock or Paper or Scissors!");
                    string action = Console.ReadLine();
                    if (action.ToLower().Equals("paper"))
                    {
                        Console.WriteLine("You Chose Paper!");
                        Console.WriteLine("");
                        Console.WriteLine("The bot chose {0}", botchoose);
                        if (botchoose.Equals("Rock"))
                        {
                            Console.WriteLine("You lost this round!");
                        }
                        else if (botchoose.Equals("Paper"))
                        {
                            Console.WriteLine("It's a tie! Neither of you won this round.");
                        }
                        else if (botchoose.Equals("Scissors"))
                        {
                            Console.WriteLine("You lost this round!");
                        }

                    }
                    if (action.ToLower().Equals("rock"))
                    {
                        Console.WriteLine("You Chose Rock!");
                        Console.WriteLine("");
                        Console.WriteLine("The bot chose {0}", botchoose);
                        if (botchoose.Equals("Rock"))
                        {
                            Console.WriteLine("It's a tie! Neither of you won this round.");
                        }
                        else if (botchoose.Equals("Paper"))
                        {
                            Console.WriteLine("You lost this round!");

                        }
                        else if (botchoose.Equals("Scissors"))
                        {
                            Console.WriteLine("You won this round!");

                        }

                    }
                    if (action.ToLower().Equals("scissors"))
                    {
                        Console.WriteLine("You Chose Scissors!");
                        Console.WriteLine("");
                        Console.WriteLine("The bot chose {0}", botchoose);
                        if (botchoose.Equals("Rock"))
                        {
                            Console.WriteLine("You lost this round!");
                        }
                        else if (botchoose.Equals("Paper"))
                        {
                            Console.WriteLine("You won this round!");
                        }
                        else if (botchoose.Equals("Scissors"))
                        {
                            Console.WriteLine("It's a tie! neither of you win this round.");
                        }

                    }
                    if (action.ToLower().Equals("scissors") && botchoose.Equals("Rock"))
                    {
                        botscore++;
                    }
                    else if (action.ToLower().Equals("paper") && botchoose.Equals("Rock"))
                    {
                        score++;
                    }
                    else if (action.ToLower().Equals("rock") && botchoose.Equals("Paper"))
                    {
                        botscore++;
                    }
                    else if (action.ToLower().Equals("scissors") && botchoose.Equals("Paper"))
                    {
                        score++;
                    }
                    else if (action.ToLower().Equals("paper") && botchoose.Equals("Scissors"))
                    {
                        botscore++;
                    }
                    else if (action.ToLower().Equals("rock") && botchoose.Equals("Scissors"))
                    {
                        score++;
                    }
                    count -= 1;
                    if (count == 0)
                    {
                        Console.WriteLine("Your score was: {0}\n" +
                            "The bots score was: {0}", score, botscore);
                        if (score == botscore)
                        {
                            Console.WriteLine();
                            Console.WriteLine("The match was a tie!");
                        }
                        Console.WriteLine("Would you like to keep playing");
                        string keepplayinglol = Console.ReadLine();
                        if (keepplayinglol.ToLower().Equals("yes"))
                        {
                            botscore = 0;
                            score = 0;
                            count += 3;
                        }
                        else
                        {
                            runNewLoop = false;
                            Main();

                        }

                    }
                }
            }
        }


        static void MemeMethod()
        {
            Console.WriteLine("Rock Paper Scissors V0.1");
            Console.WriteLine("Enter 1 to play Rock Paper Scissors");
            Console.WriteLine("Enter 2 to view credits");
            Console.WriteLine("Enter 3 to exit");
            Console.WriteLine();
        }

        static void Main()
        {

            bool runLoop = false;
            string rusure = string.Empty;

            do
            {
                MemeMethod();
                memeinput = Console.ReadLine();

                if (memeinput.Equals("1"))
                {
                    runLoop = false;
                    RockPaperScissors();
                    Console.ReadLine();
                }
                else if (memeinput.Equals("2"))
                {
                    runLoop = false;
                    Creditslol();
                    Thread.Sleep(1);
                    Console.ReadLine();
                }
                else if (memeinput.Equals("3"))
                {
                    Console.WriteLine("Are you sure you want to exit?");
                    rusure = Console.ReadLine();
                    if (rusure.ToLower().Equals("yes"))
                    {
                        System.Environment.Exit(1000);
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        MemeMethod();
                    }

                    runLoop = false;
                }
                else
                {
                    runLoop = true;
                    Console.WriteLine("Please enter one of the three options!");
                    Console.WriteLine("");
                }
            } while (runLoop);
        }

    }
}

