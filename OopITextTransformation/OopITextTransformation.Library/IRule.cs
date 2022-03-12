using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopITextTransformation.Library
{
    public interface IRule
    {
        public string Transform(string text);
    }
}
