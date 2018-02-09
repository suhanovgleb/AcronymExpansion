using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcronymExpansion
{
    static class DictionaryOfAcronyms
    {
        public static Dictionary<string, string> Dictionary()
        {
            Dictionary<string, string> acronyms = new Dictionary<string, string>();
            acronyms.Add("lol", "laugh out loud");
            return acronyms;
        }   
    }
}
