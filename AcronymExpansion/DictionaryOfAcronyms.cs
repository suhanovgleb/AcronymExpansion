using System.Collections.Generic;


namespace AcronymExpansion
{
    public static class DictionaryOfAcronyms
    {
        public static Dictionary<string, string> Dictionary()
        {
            Dictionary<string, string> acronyms = new Dictionary<string, string>
            {
                { "lol", "laugh out loud" },
                { "dw", "don't worry" },
                { "hf", "have fun" },
                { "gg", "good game" },
                { "brb", "be right back" },
                { "g2g", "got to go" },
                { "wp", "well played" },
                { "gl", "good luck" },
                { "imo", "in my opinion" }
            };
            return acronyms;
        }   
    }
}
