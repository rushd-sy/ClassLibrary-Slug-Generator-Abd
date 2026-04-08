using System.Text.RegularExpressions;

namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public static string Generate(string text)
        {
            char[] edgeSymbols = text.Where(ch => !char.IsLetter(ch)).ToArray();

            return Regex.Replace(Regex.Replace(text.ToLower().Trim(edgeSymbols),@"[^a-zA-Z_\s]+", ""),@"[_\s]+", "-"); ;
        }
    }
}
