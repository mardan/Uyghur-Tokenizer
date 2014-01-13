UyghurTokenizer
===============

A simple word level tokenizer Libary and Windows tool for Uyghur language | ئۇيغۇرچە سۆز سۈزۈش كودى ۋە قۇرالى



-------------
Usage:

            string textToTokenize = ... 
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string[] tokenizer.GetTokens(textToTokenize);

or 

            List<string> tokens = new List<string>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
                tokens.Add(iter.Current);
            return tokens.ToArray();
-------------
