
namespace InterfaceGame
{
    public class Enemy : ICharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public int AttackPower { get; private set; }

        public Enemy(string name, int maxHealth, int attackPower) 
        { 
            Name = name;
            Health = maxHealth;
            MaxHealth = maxHealth;
            AttackPower = attackPower;
        }

        public void Attack(ICharacter target) 
        { 
            target.TakeDamage(AttackPower);
            Console.WriteLine($"{Name} attacks {target.Name} and deals {AttackPower} damage!");
        }

        public void Heal() 
        { 
            //Om man vill kan fienden healas, men låter det vara tomt för att hålla det enkelt.
        }

        public bool IsAlive => Health > 0;

        public void TakeDamage(int damage) 
        { 
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage and now has {Health} health points left.");
        }
    }
}
