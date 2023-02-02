using NUnit.Framework;
using Division;


public class Tests
{
    Divider div;
    [SetUp]
    public void Setup()
    {
        div = new Divider();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
