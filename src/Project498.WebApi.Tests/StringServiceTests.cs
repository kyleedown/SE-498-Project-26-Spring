using Project498.WebApi.Services;

namespace Project498.WebApi.Tests;

public class StringServiceTests
{
    private readonly StringService _stringService = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("hello  world", "dlrow  olleh")]
    [InlineData(" hello world", "dlrow olleh ")]
    [InlineData("hello world ", " dlrow olleh")]
    public void Reverse_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.Reverse(input!);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("hello world", "world hello")]
    [InlineData("the quick brown fox", "fox brown quick the")]
    [InlineData("hello", "hello")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("one two three four five", "five four three two one")]
    [InlineData("hello  world", "world hello")]
    [InlineData("  hello  world  ", "world hello")]
    [InlineData(" leading", "leading")]
    [InlineData("trailing ", "trailing")]
    [InlineData("multiple   spaces   between", "between spaces multiple")]
    [InlineData("Hello World!", "World! Hello")]
    [InlineData("123 456 789", "789 456 123")]
    [InlineData("one-two three", "three one-two")]
    [InlineData("word", "word")]
    [InlineData("   lots    of     spaces   ", "spaces of lots")]
    public void ReverseWords_WithVariousInputs(string? input, string expected)
    {
        var result = _stringService.ReverseWords(input!);

        Assert.Equal(expected, result);
    }
}
