using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcronymExpansion
{
    static class IOWorker
    {
        static public string ReadSentence()
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

        public static void IsAgain()
        {
            bool check = false;
            do
            {
                Console.WriteLine("Do you want to write another sentence (y/n):");
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
