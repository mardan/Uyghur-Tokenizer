Uyghur Tokenizer
===============

A simple word level tokenizer Library and Windows tool for Uyghur language (Arabic-based alphabet )



Usage
---------------
Add `UyghurTokenizer.dll` as reference in your .Net project (requires .Net 2.0 or higher).            

            string textToTokenize = "Uyghur content";
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string[] tokens = tokenizer.GetTokens(textToTokenize);

or 

            List<string> tokens = new List<string>();
            IEnumerator<string> iter = GetTokenIterator(inputText);
            while (iter.MoveNext())
