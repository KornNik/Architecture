
namespace Assets.Scripts
{
    class BigEnemyFactory : IEnemyFactory
    {
        public IStats CreateStats()
        {
            return new BigEnemyStats();
        }
        public IScale CreateScale()
        {
            return new BigEnemyScale();
        }
        public IDamage CreateDamage()
        {
            return new BigEnemyDamage();
        }
    }
}
