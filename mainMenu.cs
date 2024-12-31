using System;

namespace MyGame
{
    public class MainMenu
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. View Stats");
                Console.WriteLine("2. Start Game");
                Console.WriteLine("3. Enter Buy Menu");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewStats();
                        break;
                    case "2":
                        StartGame();
                        break;
                    case "3":
                        EnterBuyMenu();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void ViewStats()
        {
            Console.Clear();

            Character character = Character.GetInstance("Krystian");
            character.viewStats();
            Console.WriteLine("Press Backspace to return to the main menu...");

            while (Console.ReadKey(true).Key != ConsoleKey.Backspace)
            {
                
            }
        }

        private void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Starting the game...");
            GameLevelStage gameLevel = new GameLevelStage();
            gameLevel.StartLevel();
            gameLevel.pickEnemy();
            Console.WriteLine("Press Backspace to return to the main menu...");

            while (Console.ReadKey(true).Key != ConsoleKey.Backspace)
            {
                
            }
        }

        private void EnterBuyMenu()
        {
            Console.Clear();
            BuyMenu buyMenu = new BuyMenu();
            buyMenu.DisplayBuyMenu();
            Console.WriteLine("Press Backspace to return to the main menu...");

            while (Console.ReadKey(true).Key != ConsoleKey.Backspace)
            {
                
            }
        }
    }
}