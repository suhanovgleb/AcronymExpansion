using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcronymExpansion
{
    static class AcronymStringReader
    {
        static public string Read()
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
    }
}
