
namespace Assets.Scripts
{
    class SmallEnemyFactory : IEnemyFactory
    {
        public IStats CreateStats()
        {
            return new SmallEnemyStats();
        }
        public IScale CreateScale()
        {
            return new SmallEnemyScale();
        }
        public IDamage CreateDamage()
        {
            return new SmallEnemyDamage();
        }
    }
}
