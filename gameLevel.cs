using System;
using System.Collections.Generic;

namespace MyGame
{
    public class GameLevelStage
    {
        private List<Enemy> enemies;

        public GameLevelStage()
        {
            enemies = new List<Enemy>();
        }

        public void StartLevel()
        {
            enemies.Add(new Enemy("Goblin", 50, 10, 5));
            enemies.Add(new Enemy("Orc", 80, 15, 10));
        }

        public void pickEnemy()
        {
            Console.WriteLine("Pick an enemy to fight:");
            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {enemies[i].Name}");
            }
            Console.Write("Choose an enemy: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Character character = Character.GetInstance("Krystian");
            character.makeChoice(enemies[choice - 1]);
        }
    }
}