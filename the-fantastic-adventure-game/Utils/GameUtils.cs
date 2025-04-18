using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Utils

{
    public static class GameUtils
    {
        public static bool PlayScene(
            string intro,
            string death, 
            string reward,
            Func<int, string> getScenarioText,
            Func<int, int, string> getOptionText,
            Func<int, int, bool> isCorrectChoice,
            Item rewardItem,
            int stageCount)
        {
            Console.Clear();
            Console.WriteLine(intro);
            Console.WriteLine();

            for (int stage = 1; stage <= stageCount; stage++)
            {
                Console.WriteLine($"--- Scenario {stage} ---");
                Console.WriteLine(getScenarioText(stage));

                Console.WriteLine("\nWhat is your action?");
                Console.WriteLine("1. " + getOptionText(stage, 1));
                Console.WriteLine("2. " + getOptionText(stage, 2));
                Console.WriteLine("3. " + getOptionText(stage, 3));
                Console.WriteLine("4. " + getOptionText(stage, 4));

                int choice = GetValidInput(1, 4);
                
                if (!isCorrectChoice(stage, choice))
                {
                    Console.WriteLine(death);
                    Console.WriteLine("\nPress any key to return to the main menu.");
                    Console.ReadKey();
                    return false; // Return to main menu
                }
            }

            Console.WriteLine(reward);
            AddToInventory(rewardItem);
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            return true; // Finished the scene
        }
        
        public static void AddToInventory(Item item)
        {
            SaveItemToFile(item);
            Console.WriteLine($"\nYou received: {item.Name} - {item.Description}");
        }

        public static void SaveItemToFile(Item item)
        {
            string folderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Saves"));
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "inventory-save.txt");
    
            File.AppendAllLines(filePath, new[] { $"{item.Name}|{item.Description}" });
        }

        public static void ShowInventory()
        {
            string folderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Saves"));
            string filePath = Path.Combine(folderPath, "inventory-save.txt");
    
            Console.WriteLine("\n--- Your Inventory ---");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("It's empty.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                Console.WriteLine("It's empty.");
                return;
            }

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Console.WriteLine($"- {parts[0]}: {parts[1]}");
                }
            }
        }
        public static void ShowInvalidChoice()
        {
            Console.WriteLine("Invalid choice, please try again.");
        }

        public static void ShowExitMessage()
        {
            Console.WriteLine("Thank you for playing The Fantastic Adventure Game. Goodbye!");
        }

        public static int GetValidInput(int min, int max)
        {
            int choice;
            bool valid = false;

            do
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= min && choice <= max)
                {
                    valid = true;
                }
                else
                {
                    ShowInvalidChoice();
                }
            } while (!valid);

            return choice;
        }
    }
}