using GameEngine.Models;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    public class BossEnemyShould
    {
        private readonly ITestOutputHelper _output;

        public BossEnemyShould(ITestOutputHelper testOutput)
        {
            _output = testOutput;
        }

        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrePower()
        {
            _output.WriteLine("Creating Boos Enemy");
            //Arrange
            BossEnemy sut = new BossEnemy();

            //Assert
            Assert.Equal(166.667, sut.SpecialSttackPower, 3);
        }
    }
}
