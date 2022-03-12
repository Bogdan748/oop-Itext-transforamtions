using OopITextTransformation.Library;
using OopITextTransformation.Library.Rules;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Ana nu are mere.";
            TextTransformationEngine engine1 = new TextTransformationEngine(
            new StringReplace("Ana", "Maria"),
            new StringDelete("nu "),
            new LowerToHigher()
            );

            TextTransformationEngine engine2 = new TextTransformationEngine(
            new StringDelete(" mere"),
            new HigherToLower()
            );

            Console.WriteLine(engine1.Transform($"Engine1: {text}"));
            Console.WriteLine(engine2.Transform($"Engine2: {text}"));
            
        }
    }
}
