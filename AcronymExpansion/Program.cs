using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcronymExpansion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write sentence with acronyms and I will convert it into full version:");
            string sentence = IOWorker.Read();
            StringWorker.ReplaceAcronyms(sentence);




            Console.ReadKey();
        }
    }
}
