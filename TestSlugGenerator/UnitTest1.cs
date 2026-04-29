using ClassLibrary_Slug_Generator_Abd;

namespace TestSlugGenerator
{
    public class UnitTest1
    {

        private readonly SlugGenerator _slugGenerator;
        public UnitTest1()
        {
            _slugGenerator = new SlugGenerator();
        }

        [Fact]
        public void SlugGenerator_Should_Return_Correct()
        {

            var input = "Hello World! ";
            var expected = "hello-world";

            var result = _slugGenerator.Generate(input);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void SlugGenerate_ShouldThrowException_WhenInputIsNull()
        {
            string input = null;

            Action act = () => _slugGenerator.Generate(input);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void SlugGenerator_Should_Handle_Empty_String()
        {
            var input = "";
            var expected = "";

            var result = _slugGenerator.Generate(input);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void SlugGenerator_Should_Handle_String_With_Only_Special_Characters()
        {
            var input = "!@#$%^&*()";
            var expected = "";
            var result = _slugGenerator.Generate(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SlugGenerator_Should_Return_Correct_Slug_InArabic()
        {
            var input = "شقة للبيع";
            var expected = "شقة-للبيع";

            var result = _slugGenerator.Generate(input);

            Assert.Equal(expected, result);

        }
    }
}
