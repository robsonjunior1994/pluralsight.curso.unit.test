using GameEngine.Models;

namespace GameEngine.Tests
{
    public class BossEnemyShould
    {
        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrePower()
        {
            //Arrange
            BossEnemy sut = new BossEnemy();

            //Assert
            Assert.Equal(166.667, sut.SpecialSttackPower, 3);
        }
    }
}
