using GameEngine.Models;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();

            //Act
            sut.Sleep();

            //Assert
            Assert.InRange(sut.Health, 101, 200);
        }

        [Fact]
        public void AnotherTest()
        {
        }

        [Theory]
        [InlineData(1)]
        public void ADataDrivenTest(int valor)
        {
        }
    }
}
