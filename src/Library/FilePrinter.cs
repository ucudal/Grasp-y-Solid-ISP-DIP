using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintableText printableText)
        {
            File.WriteAllText("Recipe.txt", printableText.GetTextToPrint());
        }
    }
}