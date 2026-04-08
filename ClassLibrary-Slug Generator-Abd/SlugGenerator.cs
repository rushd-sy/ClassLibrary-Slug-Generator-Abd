using System.Text.RegularExpressions;

namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public static string Generate(string text)
        {
            text = text.ToLower();

            char[] junk = text.Where(ch => !char.IsLetter(ch)).ToArray();
            text = text.Trim(junk);

            string pattern2 = @"[^a-zA-Z_\s]+";
            string replacement = "";
            text = Regex.Replace(text, pattern2, replacement);

            string targetSign = "-";
            string pattern1 = @"[_\s]+";
            text = Regex.Replace(text, pattern1, targetSign);

            return text;
        }
    }
}
