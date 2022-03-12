using System;


namespace OopITextTransformation.Library.Rules
{
    public class StringReplace : IRule
    {
        public StringReplace(string oldText, string newText)
        {
            OldText = oldText;
            NewText = newText;
        }

        public string OldText { get; }
        public string NewText { get; }

        public string Transform(string text)
        {
            return text.Replace(OldText, NewText);
        }
    }
}
