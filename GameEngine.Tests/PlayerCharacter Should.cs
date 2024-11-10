using GameEngine.Models;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperienceWhenNew()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();

            //Assert
            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();

            //Act
            sut.Sleep();

            //Assert
            //Assert.True(sut.Health >= 101 && sut.Health <= 200);
            Assert.InRange(sut.Health, 101, 200);

        }

        [Fact]
        public void CalculateFullName()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Robson";
            sut.LastName = "Junior";

            //Assert
            Assert.Equal("Robson Junior", sut.FullName);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Robson";
            sut.LastName = "Junior";

            //Assert
            Assert.StartsWith("Robson", sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Robson";
            sut.LastName = "Junior";

            //Assert
            Assert.EndsWith("Junior", sut.FullName);
        }

        [Fact]
        public void CalculeFullName_IgnoreCaseAssertExample()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "ROBSON";
            sut.LastName = "JUNIOR";

            //Assert
            Assert.Equal("Robson Junior", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculeFullName_SubstringAssertExample()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Robson";
            sut.LastName = "Junior";

            //Assert
            Assert.Contains("son Ju", sut.FullName);
        }

        [Fact]
        public void CalculeFullNameWithTitleCase()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            sut.FirstName = "Robson";
            sut.LastName = "Junior";

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }

        [Fact]
        public void StartWithDefaultHealth()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();

            //Assert
            Assert.Equal(100, sut.Health);
        }

        [Fact]
        public void StartWithDefaultHealth_NotEqualExample()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();

            //Assert
            Assert.NotEqual(101, sut.Health);
        }

        [Theory]
        [InlineData(1)]
        public void ADataDrivenTest(int valor)
        {
        }
    }
}
