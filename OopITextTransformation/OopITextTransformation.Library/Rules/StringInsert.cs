using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopITextTransformation.Library.Rules
{
    public class StringInsert : IRule
    {
        public StringInsert(string textToInsert, int position)
        {
            TextToInsert = textToInsert;
            Position = position;
        }
        public string TextToInsert { get; }
        public int Position { get; }

        public string Transform(string text)
        {
            return text.Insert(Position, TextToInsert);
        }
    }
}
