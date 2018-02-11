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
                var indexes = new List<int>();

                int index = sentence.IndexOf(acronym.Key, 0);

                while (index > -1)
                {
                    if (index == 0)
                    {
                        try
                        {
                            if (!char.IsLetterOrDigit(sentence, acronym.Key.Length))
                            {
                                indexes.Add(index);
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            indexes.Add(index);
                            break;
                        }
                    }
                    else if ((index + acronym.Key.Length == sentence.Length) && !char.IsLetterOrDigit(sentence, index - 1) )
                    {
                        indexes.Add(index);
                    }
                    else if (!char.IsLetterOrDigit(sentence, index - 1) && !char.IsLetterOrDigit(sentence, index + acronym.Key.Length))
                    {
                        indexes.Add(index);
                    }
                    
                    index = sentence.IndexOf(acronym.Key, index + acronym.Key.Length);
                }

                foreach (int i in indexes)
                {
                    Console.WriteLine(i);
                }


            }

            return sentence;
        }

    }
}
