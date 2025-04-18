using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Utils;

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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"--- Scenario {stage} ---");
            Console.WriteLine(getScenarioText(stage));

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWhat is your action?");
            Console.WriteLine("1. " + getOptionText(stage, 1));
            Console.WriteLine("2. " + getOptionText(stage, 2));
            Console.WriteLine("3. " + getOptionText(stage, 3));
            Console.WriteLine("4. " + getOptionText(stage, 4));

            int choice = GetValidInput(1, 4);
            
            if (!isCorrectChoice(stage, choice))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(death);
                Console.ResetColor();
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
                return false;
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(reward);
        AddToInventory(rewardItem);
        Console.ResetColor();
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        return true;
    }
    
    private static string GetSavesFolderPath()
    {
        string folderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Saves"));
        Directory.CreateDirectory(folderPath);
        return folderPath;
    }
    
    public static void AddToInventory(Item item)
    {
        SaveItemToFile(item);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou received: {item.Name} - {item.Description}");
        Console.ResetColor();
    }

    public static void SaveItemToFile(Item item)
    {
        string folderPath = GetSavesFolderPath();

        string filePath = Path.Combine(folderPath, "inventory.txt");

        File.AppendAllLines(filePath, new[] { $"{item.Name}|{item.Description}" });
    }
    
    public static bool HasItem(string itemName)
    {
        string filePath = Path.Combine(GetSavesFolderPath(), "inventory.txt");

        if (!File.Exists(filePath)) return false;

        return File.ReadLines(filePath).Any(line => line.StartsWith(itemName + "|"));
    }

    public static void ShowInventory()
    {
        string folderPath = GetSavesFolderPath();
        string filePath = Path.Combine(folderPath, "inventory.txt");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Your Inventory ---");
        Console.ResetColor();

        if (!File.Exists(filePath))
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your inventory lies barren — venture forth and claim the treasures that await!");
            Console.ResetColor();
            return;
        }

        var lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your inventory lies barren — venture forth and claim the treasures that await!");
            Console.ResetColor();
            return;
        }

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"- {parts[0]}: {parts[1]}");
                Console.ResetColor();
            }
        }
    }
    
    public static void ClearInventory()
    {
        string folderPath = GetSavesFolderPath();
        string filePath = Path.Combine(folderPath, "inventory.txt");

        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, string.Empty);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWith a solemn breath and a warrior’s resolve, you cast your burdens to the earth. Steel clatters, trinkets tumble, and the weight of past conquests is relinquished. The wind howls in approval as your pack grows light — not from loss, but from purpose. You are unshackled, unburdened... ready to carve your legend anew.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nYour inventory lies barren — venture forth and claim the treasures that await!");
            Console.ResetColor();
        }
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
    
    public static void ShowInvalidChoice()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid choice, please try again.");
        Console.ResetColor();
    }

    public static void ShowExitMessage()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Thank you for playing The Fantastic Adventure Game. Goodbye!");
        Console.ResetColor();
    }
}
