using GameEngine.Models;
using Moq;

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

        [Fact]
        public void NotHaveNickNameByDefault()
        {
            //Arrange
            PlayerCharacter sut = new PlayerCharacter();
            
            //Assert
            Assert.Null(sut.Nickname);
            //Assert.NotNull(sut.Nickname); Esse teste quebra, mas é só para mostrar outra opção.
        }

        [Fact]
        public void HaveALongBow()
        {
            //Arrange
            PlayerCharacter sut = new();

            //Assert
            Assert.Contains("Long Bow", sut.Weapons);
        }

        [Fact]
        public void NotHaveAStaffWonder()
        {
            //Arrange
            PlayerCharacter sut = new();

            //Assert
            Assert.DoesNotContain("Staff Of Wonder", sut.Weapons);
        }

        [Fact]
        public void HaveAtLeastOneKindOfSword()
        {
            //Arrange
            PlayerCharacter sut = new();

            //Assert
            Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));
        }

        [Fact]
        public void HaveAllExpectedWeapons()
        {
            PlayerCharacter sut = new();
            var expectedWeapons = new List<string>()
            {
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };

            Assert.Equal(expectedWeapons, sut.Weapons);

        }

        [Fact]
        public void HaveNoEmptyDefaultdWeapons()
        {
            PlayerCharacter sut = new();

            Assert.All(sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }

        [Theory]
        [InlineData(1)]
        public void ADataDrivenTest(int valor)
        {
        }
    }
}
