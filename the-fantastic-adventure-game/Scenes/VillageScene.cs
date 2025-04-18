using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class VillageScene
{
    public static bool Play()
    {
        Console.Clear();
        Console.WriteLine(VillageText.Intro);
        Console.WriteLine();

        for (int stage = 1; stage <= 5; stage++)
        {
            if (!HandleStage(stage))
            {
                Console.WriteLine(VillageText.Death);
                Console.WriteLine("\nPress any key to return to the main menu.");
                GameUtils.AddToInventory(new Item(
                    "Amulet of Insight",
                    "An ancient artifact radiating the power of Eldermoors ancestral memories."
                ));
                Console.ReadKey();
                return false; // Return to main menu
            }
        }

        Console.WriteLine(VillageText.Reward);
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        return true; // Finished the Village, but still return to main menu.
    }

    private static bool HandleStage(int stage)
    {
        Console.WriteLine($"--- Scenario {stage} ---");
        Console.WriteLine(VillageText.GetScenarioText(stage));

        Console.WriteLine("\nWhat is your action?");
        Console.WriteLine("1. " + VillageText.GetOptionText(stage, 1));
        Console.WriteLine("2. " + VillageText.GetOptionText(stage, 2));
        Console.WriteLine("3. " + VillageText.GetOptionText(stage, 3));
        Console.WriteLine("4. " + VillageText.GetOptionText(stage, 4));

        int choice = GameUtils.GetValidInput(1, 4);
        return VillageText.IsCorrectChoice(stage, choice);
    }
}
