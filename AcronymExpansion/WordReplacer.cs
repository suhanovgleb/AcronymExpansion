using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcronymExpansion
{
    static class StringWorker
    {
        public static string ReplaceAcronyms(string sentence)
        {
            Dictionary<string, string> acronyms = DictionaryOfAcronyms.Dictionary();

            List<string> listOfParts = SplitSentence(sentence);

            foreach (KeyValuePair<string, string> keyValue in acronyms)
            {

            }

            return sentence;
        }

        public static List<string> SplitSentence(string sentence)
        {
            string[] unfilteredParts = sentence.Split(new char[] { ' ' });
            foreach (string s in unfilteredParts)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            return null;
        }
    }
}
