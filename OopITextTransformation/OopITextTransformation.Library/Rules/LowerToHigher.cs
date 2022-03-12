using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopITextTransformation.Library.Rules
{
    public class LowerToHigher : IRule
    {
        public string Transform(string text)
        {
            string transformed = string.Empty;
            foreach(char letter in text)
            {
                if (char.IsLower(letter))
                {
                    transformed = transformed + char.ToUpper(letter);
                }
                else
                {
                    transformed = transformed + letter;
                }

            }

            return transformed;
        }
    }
}
