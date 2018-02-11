﻿using System;


namespace AcronymExpansion
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Write a sentence with acronyms, and I will convert it into its full version:");
                string sentence = IOWorker.ReadSentence();
                sentence = StringWorker.ReplaceAcronyms(sentence);
                Console.WriteLine(sentence);

                IOWorker.IsAgain();
            } while (true);
        }
    }
}
