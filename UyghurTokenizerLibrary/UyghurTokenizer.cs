// A simple word level tokenizer Libary and Windows tool for Uyghur language
// Author: Mardan hoshur (mardan.hoshur@gmail.com)
// Date: 2014-1-14
using System;
using System.Collections.Generic;
using System.Text;

namespace Uyghurdev
{
    /// <summary>
    /// Tokinizer for Arabic-based Uyghur script
    /// كونا يېزىق ئاساسىدىكى ئۇيغۇرچە سۆز سۈزگۈچ
    /// </summary>
    public class UyghurTokenizer
    {
        //this is to mark whether a given char is Uyghur letter (Unicode of a letter - '\u0600' )
        //Goal is to get higher computation speed (need to be compared with Regex)
        private bool[] mark = new bool[256]; 

        public UyghurTokenizer()
        {
            string uyghurLetter = "اەبپتجچخدرزژسشغفقكگڭلمنھوۇۆۈۋېىيئ";// total 32+1 http://en.wikipedia.org/wiki/Uyghur_alphabets
            for (int i = 0; i < mark.Length; i++)
                mark[i] = false;
            foreach (var letter in uyghurLetter)
            {
                int index = letter - '\u0600';
                mark[index] = true;
            }
        }

        public IEnumerator<string> GetTokenIterator(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
                yield break;

            bool flag = false;
            int start = 0;
            char lastChar = '\0';

            for (int i = 0; i < inputText.Length; i++)
            {
                char c = inputText[i];
                if (c > '\u0600' && c < '\u06ff' && mark[c - '\u0600'] == true)
                {
                    if (flag == false)
                    {
                        start = i;
                        flag = true;
                    }
                }
                else
                {
                    if (flag)
                    {
                        if (c != '-' || (c == '-' && lastChar == '-'))
                        {
                            if (lastChar == '-')
                                yield return inputText.Substring(start, i - start - 1);
                            else
                                yield return inputText.Substring(start, i - start);
                            flag = false;
                        }
                    }
                }
                lastChar = c;
            }
            if (flag == true)
            {
                flag = false;
                if (lastChar == '-')
                    yield return inputText.Substring(start, inputText.Length - start - 1);
                else
                    yield return inputText.Substring(start, inputText.Length - start);
            }
        }

        public string[] GetTokens(string inputText)
        {
            List<string> tokens = new List<string>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
                tokens.Add(iter.Current);
            return tokens.ToArray();
        }

        public string[] GetUniqueTokens(string inputText)
        {
            Dictionary<string, bool> tokens = new Dictionary<string, bool>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
                if (!tokens.ContainsKey(iter.Current))
                    tokens.Add(iter.Current, true);
            String[] result = new string[tokens.Count];
            tokens.Keys.CopyTo(result, 0);
            return result;
        }

        public Dictionary<string, int> GetUniqueTokensWithFreq(string inputText)
        {
            Dictionary<string, int> tokens = new Dictionary<string, int>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
                if (tokens.ContainsKey(iter.Current))
                    tokens[iter.Current] = tokens[iter.Current] + 1;
                else
                    tokens.Add(iter.Current, 1);
            return tokens;
        }
    }
}
