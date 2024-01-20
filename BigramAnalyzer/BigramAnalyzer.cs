using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/* REQUIREMENTS - GetCount method should be implemented in an optimal way, due to its potential frequent use.
 * 
 ANSWER - creating a new instance of a dictionary is likely to be more performance heavy than cleaning the dictionary. 
        This is because creating a new instance involves memory allocation and initialization,
         which can be relatively costly in terms of performance. On the other hand,
        cleaning the dictionary typically involves removing existing elements,
        which may be a more lightweight operation.
*/

namespace Bigram
{

    class BigramAnalyzer
    {

        private readonly Dictionary<string, int> bigram;
        private readonly  string[] words;
        public BigramAnalyzer(IEnumerable<string> words)
        {
            this.words = words.ToArray();
            this.bigram = new Dictionary<string, int>();
        }
        public uint GetCount(string word1, string word2)
        {



            for (int i = 0; i < this.words.Length - 1; i++)
            {
                string pair = $"{words[i]} {words[i+1]}";

                if (bigram.ContainsKey(pair))
                {
                    bigram[pair]++;
                }
                else
                {
                    bigram[pair] = 1;
                }

            }
          
            uint res = (uint)(bigram.TryGetValue($"{word1} {word2}", out int result) ? result : 0);
            this.bigram.Clear();
            return res;
        }
    }
}
 
