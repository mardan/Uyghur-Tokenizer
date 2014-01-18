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
        /// <summary>
        /// Berilgen ikki sozning Edit Distance qimmitinining pirsenleshturidu
        /// </summary>
        /// <param name="s">Birinchi soz</param>
        /// <param name="t">Ikkinchi soz</param>
        /// <returns></returns>
        private float getEditDistancePers(string s, string t)
        {
            int l = s.Length > t.Length ? s.Length : t.Length;
            int d = getEditDistance(s, t);
            float db = 1 - ((float)d / l);
            return (float)Math.Round(db, 5);

        }

        /// <summary>
        /// Berilgen ikki sozning Edit Distance qimmitini alidu
        /// </summary>
        /// <param name="s">Birinchi soz</param>
        /// <param name="t">Ikkinchi soz</param>
        /// <returns></returns>
        private int getEditDistance(string s, string t)
        {
            int n = s.Length; //length of s
            int m = t.Length; //length of t
            int[,] d = new int[n + 1, m + 1]; // matrix
            int cost; // cost
            // Step 1
            if (n == 0) return m;
            if (m == 0) return n;
            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 0; j <= m; d[0, j] = j++) ;
            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    // Bubolek sue'etni ashurush uchun ozgertildi, Mardan.
                    //cost = (secondWord.Substring(j - 1, 1) == firstWord.Substring(i - 1, 1) ? 0 : 1);
                    cost = (t[j - 1] == s[i - 1] ? 0 : 1);
                    // Step 6
                    d[i, j] = System.Math.Min(System.Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                              d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        private bool[] mark = new bool[256];

        public UyghurTokenizer()
        {
            string uyghurLetter = "اەبپتجچخدرزژسشغفقكگڭلمنھوۇۆۈۋېىيئ";
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
    }
}
