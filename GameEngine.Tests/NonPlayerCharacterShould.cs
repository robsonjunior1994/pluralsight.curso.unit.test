namespace GameEngine.Tests
{
    public class NonPlayerCharacterShould
    {
        [Theory]
        //[MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        [HealthDamageData]
        public void TakeDamage(int damage, int expectativeHealth)
        {
            PlayerCharacter sut = new();

            sut.TakeDamage(damage);

            Assert.Equal(expectativeHealth, sut.Health);
        }
    }
}
