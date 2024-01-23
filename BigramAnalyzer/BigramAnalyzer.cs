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

        private readonly Dictionary<string,uint> PairsOfWords;
        public BigramAnalyzer(IEnumerable<string> words)
        {
            this.PairsOfWords = new Dictionary<string, uint>();

            SubtotalPairsOfWords(words);

        }

        private void SubtotalPairsOfWords(IEnumerable<string> words)
        {
            string[] wordsArray = words.ToArray();
       

            for (int i = 0; i < wordsArray.Length - 1; i++)
            {
                string pair = $"{wordsArray[i]} {wordsArray[i + 1]}";

                if (PairsOfWords.ContainsKey(pair))
                {
                    PairsOfWords[pair]++;
                }
                else
                {
                    PairsOfWords[pair] = 1;
                }

            }
        } 
        public uint GetCount(string word1, string word2)
        {
            return PairsOfWords.TryGetValue($"{word1} {word2}", out uint res) ? res: 0;            
        }
    }
}
 
