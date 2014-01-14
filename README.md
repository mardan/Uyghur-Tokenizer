Uyghur Tokenizer
===============

A simple word level tokenizer Libary and Windows tool for Uyghur language (Arabic-based alphabet )



Usage:

Add UyghurTokenizer.dll as a reference in your .Net project.            

            string textToTokenize = "Uyghur content";
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string[] tokens = tokenizer.GetTokens(textToTokenize);

or 

            List<string> tokens = new List<string>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
                tokens.Add(iter.Current);
