
namespace StringLibraryTest;
using UtilityLibraries;

[TestClass]
public class StringLibraryTest
{
    [TestMethod]
    public void StartsWithUpperShouldReturnTrueIfUpperCase()
    {
        Assert.IsTrue("hello".StartsWithUpper(),"This is True");
    }
     [TestMethod]
    public void TestMethod2()
    {
    }
}