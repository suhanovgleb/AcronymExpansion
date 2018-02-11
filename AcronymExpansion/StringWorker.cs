using System;
using System.Collections.Generic;


namespace AcronymExpansion
{
    public static class StringWorker
    {
        public static string ReplaceAcronyms(string sentence) //searching and replacing acronyms
        {
            Dictionary<string, string> acronyms = DictionaryOfAcronyms.Dictionary();

            foreach (KeyValuePair<string, string> acronym in acronyms)
            {

                int index = sentence.IndexOf(acronym.Key, StringComparison.OrdinalIgnoreCase);

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
                        catch (ArgumentOutOfRangeException) //if the sentence contains only one acronym and nothing else
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
                    
                    index = sentence.IndexOf(acronym.Key, index + acronym.Key.Length, StringComparison.OrdinalIgnoreCase);
                }

            }

            return sentence;
        }

        public static string ReplaceAcronym (string sentence, int startFromIndex, KeyValuePair<string, string> acronym) //replaces one acronym with the full version
        {
            sentence = sentence.Remove(startFromIndex, acronym.Key.Length);
            sentence = sentence.Insert(startFromIndex, acronym.Value);

            return sentence;
        }
    }
}
