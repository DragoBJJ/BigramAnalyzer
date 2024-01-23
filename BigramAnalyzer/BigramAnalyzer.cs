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

        private readonly Dictionary<string,uint> bigram;
        public BigramAnalyzer(IEnumerable<string> words)
        {
            string[] wordsArray = words.ToArray();
            bigram = new Dictionary<string, uint>(wordsArray.Length / 2);
            SubtotalSpeeches(wordsArray);

        }

        private  void SubtotalSpeeches(string[] wordsArray)
        {
            for (int i = 0; i < wordsArray.Length - 1; i++)
            {
                string pair = $"{wordsArray[i]} {wordsArray[i + 1]}";

                if (bigram.ContainsKey(pair))
                {
                    bigram[pair]++;
                }
                else
                {
                    bigram[pair] = 1;
                }

            }
        } 
        public uint GetCount(string w1, string w2)
        {

            return bigram.TryGetValue($"{w1} {w2}", out uint res) ? res: 0;
             
        }
    }
}
 
