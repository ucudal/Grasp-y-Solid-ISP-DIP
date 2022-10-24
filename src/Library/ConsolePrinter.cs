using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IPrintableText printableText)
        {
            Console.WriteLine(printableText.GetTextToPrint());
        }
    }
}