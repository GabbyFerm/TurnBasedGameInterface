
namespace InterfaceGame
{
    public class Player : ICharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public int AttackPower { get; private set; }

        // Konstruktor för att sätta namn, max hälsa och attackstyrka
        public Player(string name, int maxHealth, int attackPower)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth; // Hälsan börjar vid maxvärde
            AttackPower = attackPower;
        }

        public void Attack(ICharacter target) 
        { 
            target.TakeDamage(AttackPower);
            Console.WriteLine($"{Name} attacks {target.Name} and deals {AttackPower} damage!");
        }

        public void Heal() 
        {
            Health += 5; //Hur mycket vi healar
            if (Health > MaxHealth) 
            { 
                Health = MaxHealth;
            }
        }

        public bool IsAlive => Health > 0;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage and now has {Health} health points left.");
        }
    }
}
