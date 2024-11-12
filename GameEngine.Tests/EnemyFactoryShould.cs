using GameEngine.Models;

namespace GameEngine.Tests
{
    [Trait("Category", "Enemy")]
    public class EnemyFactoryShould
    {
        [Fact]
        public void CreateNormalEnemyByDefault()
        {
            EnemyFactory sut = new();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsType<NormalEnemy>(enemy);
        }

        [Fact]
        public void CreateNormalEnemyByDefault_NotTypeExample()
        {
            EnemyFactory sut = new();

            Enemy enemy = sut.Create("Zombie");

            Assert.IsNotType<DateTime>(enemy);
        }

        [Fact]
        public void CreateBossEnemy()
        {
            //Arrange
            EnemyFactory sut = new EnemyFactory();

            //Act
            Enemy response = sut.Create("Zombie King", true);

            //Assert
            Assert.IsType<BossEnemy>(response);
        }

        [Fact]
        public void CreateBossEnemy_CastReturnedTypeExample()
        {
            //Arrange
            EnemyFactory sut = new EnemyFactory();

            //Act
            Enemy response = sut.Create("Zombie King", true);

            //Assert
            BossEnemy boss = Assert.IsType<BossEnemy>(response);

            Assert.Equal("Zombie King", boss.Name);
        }

        [Fact]
        public void CreateBossEnemy_AssertAssignableTypes()
        {
            //Arrange
            EnemyFactory sut = new EnemyFactory();

            //Act
            Enemy response = sut.Create("Zombie King", true);

            //Assert
            //Assert.IsType<Enemy>(response);
            Assert.IsAssignableFrom<Enemy>(response);
        }

        [Fact]
        public void CreateSepareInstances()
        {
            EnemyFactory sut = new();

            Enemy enemy1 = sut.Create("Zombie");
            Enemy enemy2 = sut.Create("Zombie");

            // Esse método verifica se não são da mesma instância
            Assert.NotSame(enemy1, enemy2);

        }

        [Fact]
        public void CreateIqualInstances()
        {
            EnemyFactory sut = new();

            Enemy enemy1 = sut.Create("Zombie");
            Enemy enemy2 = enemy1;


            // Esse método verifica se não são da mesma instância
            Assert.Same(enemy1, enemy2);
        }

        [Fact]
        public void NotAllowNullName()
        {
            EnemyFactory sut = new();

            //Assert.Throws<ArgumentNullException>(() => sut.Create(null));
            Assert.Throws<ArgumentNullException>("name", () => sut.Create(null));
        }

        [Fact]
        public void OnlyAllowKingOrQueenBossEnemies()
        {
            EnemyFactory sut = new();

            EnemyCreationException ex = Assert.Throws<EnemyCreationException>(() => sut.Create("Zombi rei", true)); 

            Assert.Equal("Zombi rei", ex.RequestedEnemyName);
        }

        [Fact]
        public void OnlyAllowKingOrQueenBossEnemiesOption2()
        {
            EnemyFactory sut = new();

            var response = new Action(() => sut.Create("Zombi rei", true));

            EnemyCreationException ex = Assert.Throws<EnemyCreationException>(response);

            Assert.Equal("Zombi rei", ex.RequestedEnemyName);
        }
    }
}
