using System.Text.RegularExpressions;

namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public static string Generate(string text)
        {
            return string.Join("-", new string(text.Where(ch => char.IsLetter(ch) || ch == ' ' || ch == '_').ToArray()).ToLower().Split(new char[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
