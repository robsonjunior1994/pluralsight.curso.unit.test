namespace GameEngine.Models
{
    public class EnemyFactory
    {
        public Enemy Create(string name, bool isBoos = false)
        {
            if(name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (isBoos) 
            {
                if (!IsValidBossName(name))
                { 
                    throw new EnemyCreationException(
                        $"{name} is not a valid name for a Boss enemy, Boss enemy names must end with 'King' or 'Queen'",
                        name);
                }

                return new BossEnemy { Name = name };
            }

            return new NormalEnemy { Name = name };
        }

        private bool IsValidBossName(string name) => name.EndsWith("King") ||
                                             name.EndsWith("Queen");
    }
}
