using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopITextTransformation.Library.Rules
{
    public class HigherToLower : IRule
    {
        public string Transform(string text)
        {
            string transformed = string.Empty;
            foreach (char letter in text)
            {
                if (char.IsUpper(letter))
                {
                    transformed = transformed + char.ToLower(letter);
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
