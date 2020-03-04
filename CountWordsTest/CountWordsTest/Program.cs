using System;
using System.Collections.Generic;

namespace CountWordsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
            {
                "java", //aajv
                "jjava",//aajjv
                "vaj",  //ajv
                "aavj", //aajv
                "j",    //j
                "vjaa", //aajv
                "dan",  // adn
                "and",  //adn
                "ddan" //addn
            };
            CheckMe(words);
        }
        static Dictionary<string, int> CheckMe(List<string> words)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sorted = new string(chars);
                if (counter.ContainsKey(sorted))
                    counter[sorted]++;
                else
                    counter.Add(sorted, 1);
            }

            foreach (KeyValuePair<string, int> kvp in counter)
            {
                Console.Write($"{kvp.Key} : {kvp.Value}");
            }

            return counter;

        }
    }
}
