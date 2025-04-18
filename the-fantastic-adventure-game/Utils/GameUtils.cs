using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Utils

{
    public static class GameUtils
    {
        private static List<Item> Inventory = new();

        public static void AddToInventory(Item item)
        {
            Inventory.Add(item);
            SaveInventoryToFile();
            Console.WriteLine($"\nYou received: {item.Name} - {item.Description}");
        }
        
        public static void SaveInventoryToFile()
        {
            string folderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Saves"));
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "inventory-save.txt");
            var lines = Inventory.Select(item => $"{item.Name}|{item.Description}");
            File.WriteAllLines(filePath, lines);
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