using System;

namespace AcronymExpansion
{
    public static class IOWorker
    {
        static public string ReadSentence() //Reads sentence from console
        {
            string acronymString = null;

            while (true)
            {
                try
                {
                    acronymString = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong...");
                }

                switch (acronymString)
                {
                    case "":
                        Console.WriteLine("The entered string is empty. Please enter another string:");
                        break;
                    default:
                        return acronymString;
                }

            }


        }

        public static void IsAgain() //Asks if you want to enter another sentence. Also contains the exit point from the application.
        {
            bool check = false;
            do
            {
                Console.WriteLine("Do you want to enter another sentence (y/n):");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'y':
                        check = true;
                        Console.WriteLine();
                        break;
                    case 'n':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nThe entered char is not 'n' or 'y'. Please try again.");
                        break;
                }
            } while (!check);
        }
    }
}
