using Xunit;
using TestService.Controllers;


namespace TestServiceTests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            ValuesController ctrlr = new TestService.Controllers.ValuesController();
            string str = ctrlr.Get(5);
            Assert.Equal(str, "value");
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
