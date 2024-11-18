using Xunit.Abstractions;

namespace GameEngine.Tests
{
    [Trait("Category", "Player")]
    public class PlayerCharacterShould : IDisposable
    {
        private readonly PlayerCharacter _sut;
        private readonly ITestOutputHelper _output;

        public PlayerCharacterShould(ITestOutputHelper output)
        {
            _output = output;
            
            _output.WriteLine("Creating new PlayerCharacter");
            _sut = new PlayerCharacter();
            _output.WriteLine($"Disposing PlayerCharacter {_sut.FullName}");


        }
        public void Dispose()
        {
            _output.WriteLine($"Disposing PlayerCharacter {_sut.FullName}");
        }

        [Fact]
        public void BeInexperienceWhenNew()
        {
            //Arrange
            

            //Assert
            Assert.True(_sut.IsNoob);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            //Arrange


            //Act
            _sut.Sleep();

            //Assert
            //Assert.True(_sut.Health >= 101 && _sut.Health <= 200);
            Assert.InRange(_sut.Health, 101, 200);

        }

        [Fact]
        public void CalculateFullName()
        {
            //Arrange

            _sut.FirstName = "Robson";
            _sut.LastName = "Junior";

            //Assert
            Assert.Equal("Robson Junior", _sut.FullName);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            //Arrange

            _sut.FirstName = "Robson";
            _sut.LastName = "Junior";

            //Assert
            Assert.StartsWith("Robson", _sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            //Arrange

            _sut.FirstName = "Robson";
            _sut.LastName = "Junior";

            //Assert
            Assert.EndsWith("Junior", _sut.FullName);
        }

        [Fact(Skip = "Exemplo of skip test")]
        public void CalculeFullName_IgnoreCaseAssertExample()
        {
            //Arrange
            
            _sut.FirstName = "ROBSON";
            _sut.LastName = "JUNIOR";

            //Assert
            Assert.Equal("Robson Junior", _sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculeFullName_SubstringAssertExample()
        {
            //Arrange
            
            _sut.FirstName = "Robson";
            _sut.LastName = "Junior";

            //Assert
            Assert.Contains("son Ju", _sut.FullName);
        }

        [Fact]
        public void CalculeFullNameWithTitleCase()
        {
            //Arrange
            
            _sut.FirstName = "Robson";
            _sut.LastName = "Junior";

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", _sut.FullName);
        }

        [Fact]
        public void StartWithDefaultHealth()
        {
            //Arrange
            

            //Assert
            Assert.Equal(100, _sut.Health);
        }

        [Fact]
        public void StartWithDefaultHealth_NotEqualExample()
        {
            //Arrange
            

            //Assert
            Assert.NotEqual(101, _sut.Health);
        }

        [Fact]
        public void NotHaveNickNameByDefault()
        {
            //Arrange
            
            
            //Assert
            Assert.Null(_sut.Nickname);
            //Assert.NotNull(_sut.Nickname); Esse teste quebra, mas é só para mostrar outra opção.
        }

        [Fact]
        public void HaveALongBow()
        {
            //Arrange
            

            //Assert
            Assert.Contains("Long Bow", _sut.Weapons);
        }

        [Fact]
        public void NotHaveAStaffWonder()
        {
            //Arrange
            

            //Assert
            Assert.DoesNotContain("Staff Of Wonder", _sut.Weapons);
        }

        [Fact]
        public void HaveAtLeastOneKindOfSword()
        {
            //Arrange
            

            //Assert
            Assert.Contains(_sut.Weapons, weapon => weapon.Contains("Sword"));
        }

        [Fact]
        public void HaveAllExpectedWeapons()
        {
            
            var expectedWeapons = new List<string>()
            {
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };

            Assert.Equal(expectedWeapons, _sut.Weapons);

        }

        [Fact]
        public void HaveNoEmptyDefaultdWeapons()
        {
            

            Assert.All(_sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }

        [Fact]
        public void RaiseSleepEvent()
        {
            

            Assert.Raises<EventArgs>(
                handler => _sut.PlayerSlept += handler, //anexa o evento
                handler => _sut.PlayerSlept -= handler, //desanexa o evento
                //3º parametro é ação que deve fazer com que esse evento seja gerado
                () => _sut.Sleep()
                );
        }

        [Fact]
        public void RaisePropertyChangedEvent()
        {
            

            Assert.PropertyChanged(_sut, "Health", () => _sut.TakeDamage(10));
        }

        [Theory]
        [InlineData(1)]
        public void ADataDrivenTest(int valor)
        {
        }

    }
}
