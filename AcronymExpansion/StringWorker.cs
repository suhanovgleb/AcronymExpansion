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

            foreach (KeyValuePair<string, string> acronym in acronyms)
            {

                int index = sentence.IndexOf(acronym.Key);

                while (index > -1) //will exit the loop when IndexOff() doesn't find the entry of the acronym in the string 
                {
                    if (index == 0)
                    {
                        try
                        {
                            if (!char.IsLetterOrDigit(sentence, acronym.Key.Length))
                            {
                                sentence = ReplaceAcronym(sentence, index, acronym);
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            sentence = ReplaceAcronym(sentence, index, acronym);
                            break;
                        }
                    }
                    else if ( (index + acronym.Key.Length == sentence.Length) && !char.IsLetterOrDigit(sentence, index - 1) )
                    {
                        sentence = ReplaceAcronym(sentence, index, acronym);
                    }
                    else if (!char.IsLetterOrDigit(sentence, index - 1) && !char.IsLetterOrDigit(sentence, index + acronym.Key.Length))
                    {
                        sentence = ReplaceAcronym(sentence, index, acronym);
                    }
                    
                    index = sentence.IndexOf(acronym.Key, index + acronym.Key.Length);
                }

            }

            return sentence;
        }

        private static string ReplaceAcronym (string sentence, int startFromIndex, KeyValuePair<string, string> acronym)
        {
            sentence = sentence.Remove(startFromIndex, acronym.Key.Length);
            sentence = sentence.Insert(startFromIndex, acronym.Value);

            return sentence;
        }
    }
}
