namespace Abstractions
{
    public interface IAttackable : IHealth
    {
        void RecieveDamage(int amount);
    }
}