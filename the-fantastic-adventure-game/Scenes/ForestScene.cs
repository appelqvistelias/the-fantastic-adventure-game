using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class ForestScene
{
    public static bool Play()
    {
        Console.Clear();
        Console.WriteLine(ForestText.Intro);
        Console.WriteLine();

        for (int stage = 1; stage <= 5; stage++)
        {
            if (!HandleStage(stage))
            {
                Console.WriteLine(ForestText.Death);
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
                return false; // Return to main menu
            }
        }

        Console.WriteLine(ForestText.Reward);
        Console.WriteLine("\nPress any key to return to the main menu.");
        GameUtils.AddToInventory(new Item(
            "Mystical Forest Crystal",
            "An ancient artifact radiating the power of the Shadow Wood."
        ));
        Console.ReadKey();
        return true; // Finished the Village, but still return to main menu.
    }

    private static bool HandleStage(int stage)
    {
        Console.WriteLine($"--- Scenario {stage} ---");
        Console.WriteLine(ForestText.GetScenarioText(stage));

        Console.WriteLine("\nWhat is your action?");
        Console.WriteLine("1. " + ForestText.GetOptionText(stage, 1));
        Console.WriteLine("2. " + ForestText.GetOptionText(stage, 2));
        Console.WriteLine("3. " + ForestText.GetOptionText(stage, 3));
        Console.WriteLine("4. " + ForestText.GetOptionText(stage, 4));

        int choice = GameUtils.GetValidInput(1, 4);
        return ForestText.IsCorrectChoice(stage, choice);
    }
}