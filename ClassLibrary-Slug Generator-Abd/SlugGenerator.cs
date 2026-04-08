using System.Text.RegularExpressions;

namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public static string Generate(string text)
        {
            text = text.ToLower();

            char[] edgeSymbols = text.Where(ch => !char.IsLetter(ch)).ToArray();
            text = text.Trim(edgeSymbols);

            string invalidCharsPattern = @"[^a-zA-Z_\s]+";
            text = Regex.Replace(text, invalidCharsPattern, "");

            string wordSeparatorsPattern = @"[_\s]+";
            text = Regex.Replace(text, wordSeparatorsPattern, "-");

            return text;
        }
    }
}
