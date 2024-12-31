namespace MyGame
{
    public class Character
    {
        private static Character instance;

        public string Name { get; set; }
        public int Money { get; set; } = 10;
        public int maxHealth { get; set; } = 100;
        public int currentHealth { get; set; } = 100;
        public int attack { get; set; } = 5;
        public int defense { get; set; } = 0;

        // private constructor
        private Character(string name)
        {
            Name = name;
        }

        // singleton
        public static Character GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new Character(name);
            }
            return instance;
        }

        public void AttackEnemy(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Name}!");
            enemy.takeDamage(attack);
        }

        public void takeDamage(int damage)
        {
            int damageTaken = damage - defense;
            if (damageTaken > 0)
            {
                currentHealth -= damageTaken;
            }
        }

        public void viewStats()
        {
            Console.WriteLine($"========================================================================");
            Console.WriteLine($"=  Name:    {Name,-41} =     ----       =");
            Console.WriteLine($"=  Money:   {Money,-41} =    -    -      =");
            Console.WriteLine($"=  Health:  {currentHealth + "/" + maxHealth,-41} =     ----       =");
            Console.WriteLine($"=  Attack:  {attack,-41} ==================");
            Console.WriteLine($"=  Defense: {defense,-41}                  =");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"==============================Inventory=================================");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"=                                                                      =");
            Console.WriteLine($"========================================================================");
        }

        public void viewChoices()
        {   
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Item");
            Console.WriteLine("3. Run");
            Console.WriteLine("Press Backspace to return to the main menu...");

            while (Console.ReadKey(true).Key != ConsoleKey.Backspace)
            {
                    
            }
        }

        public void makeChoice(Enemy enemy)
        {
            Console.Clear();
            viewChoices();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AttackEnemy(enemy);
                    break;
                case "2":
                    Console.WriteLine("view stats");
                    enemy.viewProgress();
                    break;
                case "3":
                    Console.WriteLine("You ran away!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}