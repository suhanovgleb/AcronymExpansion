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
                for (int i = 0; i < listOfParts.Count; i++)
                {
                    if(keyValue.Key == listOfParts[i])
                    {
                        listOfParts[i] = keyValue.Value;
                    }
                }
            }

            
            sentence = String.Join(" ", listOfParts);
            

            Console.WriteLine(sentence);

            return sentence;
        }

        public static List<string> SplitSentence(string sentence)
        {
            List<string> listOfParts = new List<string>(); 
            string[] unfilteredParts = sentence.Split(new char[] { ' ' });

            foreach (string unfilteredPart in unfilteredParts)
            {
                listOfParts.Add(unfilteredPart);
            }

            return listOfParts;
        }
    }
}
