using System;
using System.Threading;


namespace RockPaperScissors
{
    class Program
    {
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
            int i9 = 1;

            while (i9 == 1)
            {
                string response = Console.ReadLine();
                if (response.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    i9 = 0;
                }
            }

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
                    botchoose = "Paper";
                else if (numgen == 2)
                    botchoose = "Rock";
                else if (numgen == 3)
                    botchoose = "Scissors";

                Console.WriteLine("Enter Rock or Paper or Scissors!");
                string action = Console.ReadLine();

                if (action.Equals("paper", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("You Chose Paper!");
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("The bot chose {0}!", botchoose);

                    if (botchoose.Equals("Rock"))
                    {
                        Console.WriteLine("You won this round!");
                        score++;
                    }
                    else if (botchoose.Equals("Paper"))
                    {
                        Console.WriteLine("It's a tie! Neither of you won this round.");
                    }
                    else if (botchoose.Equals("Scissors"))
                    {
                        Console.WriteLine("You lost this round!");
                        botscore++;
                    }

                }
                if (action.Equals("rock", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("You Chose Rock!");
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("The bot chose {0}!", botchoose);

                    if (botchoose.Equals("Rock"))
                    {
                        Console.WriteLine("It's a tie! Neither of you won this round.");
                    }
                    else if (botchoose.Equals("Paper"))
                    {
                        Console.WriteLine("You lost this round!");
                        botscore++;
                    }
                    else if (botchoose.Equals("Scissors"))
                    {
                        Console.WriteLine("You won this round!");
                        score++;
                    }
                }
                if (action.Equals("scissors", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("You Chose Scissors!");
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("The bot chose {0}", botchoose);

                    if (botchoose.Equals("Rock"))
                    {
                        Console.WriteLine("You lost this round!");
                        botscore++;
                    }
                    else if (botchoose.Equals("Paper"))
                    {
                        Console.WriteLine("You won this round!");
                        score++;
                    }
                    else if (botchoose.Equals("Scissors"))
                    {
                        Console.WriteLine("It's a tie! neither of you win this round.");
                    }
                }

                count -= 1;

                if (count == 0)
                {
                    Console.WriteLine("Your score was: {0}", score);
                    Console.WriteLine("The bots score was: {0}", botscore);

                    if (score == botscore)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The match was a tie!");
                    }

                    Console.WriteLine("Would you like to keep playing");
                    string keepplayinglol = Console.ReadLine();

                    if (keepplayinglol.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                    {
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
                    if (rusure.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
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
                    Console.WriteLine(string.Empty);
                }
            } while (runLoop);
        }
    }
}

