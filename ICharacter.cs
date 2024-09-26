
namespace InterfaceGame
{
    public interface ICharacter
    {
        string Name { get; }
        int Health { get; }
        int MaxHealth { get; }
        int AttackPower { get; }

        void Attack(ICharacter target);
        void Heal();
        void TakeDamage(int damage);
        bool IsAlive { get; }
    }
}
