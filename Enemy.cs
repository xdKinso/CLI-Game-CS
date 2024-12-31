namespace MyGame
{
    public class Enemy
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; } 
        public int CurrentHealth { get; set; } // Removed default value assignment

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }

        public Enemy(string name, int health, int attack, int defense)
        {
            Name = name;
            MaxHealth = health;
            CurrentHealth = health; // Initialize CurrentHealth
            Attack = attack;
            Defense = defense;
            Gold = generateGold();
        }

        public int generateGold()
        {
            Random rnd = new Random();
            int randomgold = rnd.Next(1, 10); // Declare randomgold
            return randomgold;
        }

        public void attackPlayer()
        {
            Character character = Character.GetInstance("Krystian"); // Get character instance
            character.takeDamage(Attack); // Corrected method call
        }

        public void takeDamage(int damage)
        {
            int damageTaken = damage - Defense;
            if (damageTaken > 0) 
            {
                CurrentHealth -= damageTaken;
            }
        }

        public void viewProgress()
        {
            Console.WriteLine($"========================================================================");
            Console.WriteLine($"=  Name:    {Name,-41} =     ----       =");
            Console.WriteLine($"=  Health:  {CurrentHealth + "/" + MaxHealth,-41}          =");
            Console.WriteLine($"=  Attack:  {Attack,-41}                  =");
            Console.WriteLine($"=  Defense: {Defense,-41}                 =");
            Console.WriteLine($"========================================================================");
        }
    }
}