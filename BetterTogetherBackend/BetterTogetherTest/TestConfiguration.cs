namespace BetterTogetherTest;

public class TestConfiguration
{
    [Fact]
    public void DummyTest1()
    {
        Assert.True(true, "True is not true");
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void DummyTest2(int inputValue)
    {
        var result = Math.Abs(inputValue) <= 1;
        
        Assert.True(result, "");
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void DummyTest3(int inputValue)
    {
        var result = inputValue > 0;
        
        Assert.True(result, "Positive value is negative");
    }
}