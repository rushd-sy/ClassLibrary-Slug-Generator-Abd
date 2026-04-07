namespace ClassLibrary_Slug_Generator_Abd
{
    public class SlugGenerator
    {
        public static string Generate(string text)
        {
            text = text.ToLower();

            int start = 0;
            while (start < text.Length && !Char.IsLetter(text[start]))
                start++;

            int end = text.Length - 1;
            while (end >= 0 && !Char.IsLetter(text[end]))
                end--;

            text = text.Substring(start, end - start + 1);

            string slug = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                    slug += text[i];
                else
                {
                    int j = i;
                    bool isSeparator = false;
                    while (j < text.Length && !Char.IsLetter(text[j]))
                    {
                        if (text[j] == ' ' || text[j] == '_')
                            isSeparator = true;
                        j++;
                    }
                    if (isSeparator)
                        slug += '-';
                    i = j - 1;
                }
            }
            return slug;
        }
    }
}
