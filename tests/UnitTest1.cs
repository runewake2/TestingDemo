namespace tests;

public class UnitTest1
{
    [Fact]
    public void Addition()
    {
        var sum = 1 + 1;
        Assert.Equal(2, sum);
    }
    
    [Fact]
    public void Subtraction()
    {
        var sum = 4 - 2;
        Assert.Equal(2, sum);
    }

    [Fact]
    public void Multiplication()
    {
        var sum = 1 * 2;
        Assert.Equal(2, sum);
    }
}