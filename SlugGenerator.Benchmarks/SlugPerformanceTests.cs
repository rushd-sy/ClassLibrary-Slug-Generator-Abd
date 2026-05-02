using BenchmarkDotNet.Attributes;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

[MemoryDiagnoser] 
public class SlugPerformanceTests
{
    private const string test = "شقة - Apartment for Sale 2024!!!";

    [Benchmark(Baseline = true)] 
    public string Generator()
    {
        if (test == null)
        {
            throw new ArgumentNullException(nameof(test));
        }

        return string.Join("-", test
        .Where(ch => char.IsLetter(ch) || ch == ' ' || ch == '_')
        .ToArray()
        .AsMemory()
        .ToString()
        .ToLowerInvariant()
        .Split(new[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries)
);

    }

    
    [Benchmark]
    public string StandardRegexSlugGenerator() 
    {
        string str = test.ToLowerInvariant();

        str = Regex.Replace(str, @"[^a-z0-9\u0600-\u06FF\s-]", "");

        str = Regex.Replace(str, @"\s+", " ").Trim();

        str = Regex.Replace(str, @"\s", "-");

        return str;
    }
}