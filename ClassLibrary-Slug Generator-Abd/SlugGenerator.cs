using System.Text.RegularExpressions;

namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public string Generate(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            return string.Join("-", text
            .Where(ch => char.IsLetter(ch) || ch == ' ' || ch == '_')
            .ToArray()                                               
            .AsMemory()                                             
            .ToString()
            .ToLower()                                               
            .Split(new[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries) 
);
        }
    }
}
