using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bigram
{

    class BigramAnalyzer
    {

        private readonly Dictionary<string, uint> bigram;
        private readonly  string[] words;
        public BigramAnalyzer(IEnumerable<string> words)
        {
            this.words = words.ToArray();
            this.bigram = new Dictionary<string, uint>();
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

            uint res = bigram.TryGetValue($"{word1} {word2}", out uint result) ? result : 0;
            this.bigram.Clear();
            return res;
        }
    }
}
 
