using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopITextTransformation.Library.Rules
{
    public class StringDelete : IRule
    {
        public StringDelete(string textToDelete)
        {
            TextToDelete = textToDelete;
        }

        public string TextToDelete { get; }
        

        public string Transform(string text)
        {
            return text.Replace(TextToDelete, String.Empty);
        }
    }
}
