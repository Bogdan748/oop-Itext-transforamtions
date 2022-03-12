
namespace OopITextTransformation.Library
{
    public  class TextTransformationEngine
    {
        public TextTransformationEngine(params IRule[] rules)
        {
            Rules = rules ?? new IRule[0];
        }
        public  IRule[] Rules { get; }

        public string Transform(string text)
        {

            foreach (IRule rule in Rules)
            {
                text = rule.Transform(text);
            }
            return text;
        }
    }
}
