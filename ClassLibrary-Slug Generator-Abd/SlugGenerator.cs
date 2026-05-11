namespace ClassLibrary_Slug_Generator_Abd
{
    public static class SlugGenerator
    {
        public static string Generate(string text)
        {
            ArgumentNullException.ThrowIfNull(text);

            return string.Join("-", text
            .Where(ch => char.IsLetter(ch) || ch == ' ' || ch == '_')
            .ToArray()                                               
            .AsMemory()                                             
            .ToString()
            .ToLowerInvariant()
            .Split(new[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries) 
);
        }


        public static string GenerateUnique(string text)
        {
            System.Guid guid = System.Guid.NewGuid();
            return guid.ToString();
        }

    }
}
