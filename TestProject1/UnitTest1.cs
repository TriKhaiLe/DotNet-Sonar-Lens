using DotNetSonarLens;
using DotNetSonarLens.Controllers;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController controller = new WeatherForecastController();
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
            Assert.Equal(5, result.Count());

        }
    }
}