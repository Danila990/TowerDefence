
namespace TD
{
    public interface IDamageable
    {
        public bool IsAlive { get; }

        public void TakeDamage(float damage);
    }
}