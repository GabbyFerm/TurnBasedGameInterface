namespace InterfaceGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Välkomst text
            Console.WriteLine("Welcome to the game. Do you want to play? (yes/no)");
            string startResponse = Console.ReadLine()!;

            // Hantera respons
            if (startResponse.ToLower() == "yes")
            {
                Console.WriteLine("The battle begins!");

                // Skapa instanser av Player och Enemy
                Player player = new Player("Hero", 40, 5);
                Enemy enemy = new Enemy("Goblin", 20, 5);

                // Spel loop
                while (player.IsAlive && enemy.IsAlive)
                {
                    // Player turn
                    Console.WriteLine("-- Player turn --");
                    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                    string choice = Console.ReadLine()!;

                    if (choice == "a")
                    {
                        player.Attack(enemy);
                    }
                    else if (choice == "h")
                    {
                        player.Heal();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'a' or 'h'.");
                        continue; // Gå tillbaka till början av loopen
                    }

                    // Enemy turn
                    if (enemy.IsAlive)
                    {
                        Console.WriteLine("-- Enemy turn --");
                        enemy.Attack(player);
                    }
                }

                // Kontrollera resultatet av spelet
                if (player.IsAlive)
                {
                    Console.WriteLine("Congratulations, you have won!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are defeated!");
                }
            }
            else
            {
                // End game if player doesn't want to play
                Console.WriteLine("Maybe next time! Exiting the game.");
            }
        }
    }
}
