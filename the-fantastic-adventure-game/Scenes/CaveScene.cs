using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class CaveScene
{
    public static bool Play()
    {
        Console.Clear();
        Console.WriteLine(CaveText.Intro);
        Console.WriteLine();

        for (int stage = 1; stage <= 5; stage++)
        {
            if (!HandleStage(stage))
            {
                Console.WriteLine(CaveText.Death);
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
                return false; // Return to main menu
            }
        }

        Console.WriteLine(CaveText.Reward);
        Console.WriteLine("\nPress any key to return to the main menu.");
        GameUtils.AddToInventory(new Item(
            "Crystal of Echoes",
            "An ancient artifact radiating the power of Murmurdeep Caverns."
        ));
        Console.ReadKey();
        return true; // Finished the Cave, but still return to main menu.
    }

    private static bool HandleStage(int stage)
    {
        Console.WriteLine($"--- Scenario {stage} ---");
        Console.WriteLine(CaveText.GetScenarioText(stage));

        Console.WriteLine("\nWhat is your action?");
        Console.WriteLine("1. " + CaveText.GetOptionText(stage, 1));
        Console.WriteLine("2. " + CaveText.GetOptionText(stage, 2));
        Console.WriteLine("3. " + CaveText.GetOptionText(stage, 3));
        Console.WriteLine("4. " + CaveText.GetOptionText(stage, 4));

        int choice = GameUtils.GetValidInput(1, 4);
        return CaveText.IsCorrectChoice(stage, choice);
    }
}