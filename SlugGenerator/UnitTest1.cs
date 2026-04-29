using System;
using Xunit;

namespace SlugGenerator
{
    public class UnitTest1
    {
        [Fact]
        public void SlugGenerator_ShouldGenerateSlug()
        {
            string input = "Hello World! This is a test.";
            string expectedResult = "hello-world-this-is-a-test";
            
            string actualResult = SlugGenerator.Generate(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
    
}
