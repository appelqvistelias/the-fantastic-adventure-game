using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class LakeScene
{
    public static bool Play()
    {
        Console.Clear();
        Console.WriteLine(LakeText.Intro);
        Console.WriteLine();

        for (int stage = 1; stage <= 5; stage++)
        {
            if (!HandleStage(stage))
            {
                Console.WriteLine(LakeText.Death);
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
                return false; // Return to main menu
            }
        }

        Console.WriteLine(LakeText.Reward);
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        GameUtils.AddToInventory(new Item(
            "Relic of Tides",
            "An ancient artifact radiating the power of Lake Somberveil."
        ));
        return true; // Finished the Village, but still return to main menu.
    }

    private static bool HandleStage(int stage)
    {
        Console.WriteLine($"--- Scenario {stage} ---");
        Console.WriteLine(LakeText.GetScenarioText(stage));

        Console.WriteLine("\nWhat is your action?");
        Console.WriteLine("1. " + LakeText.GetOptionText(stage, 1));
        Console.WriteLine("2. " + LakeText.GetOptionText(stage, 2));
        Console.WriteLine("3. " + LakeText.GetOptionText(stage, 3));
        Console.WriteLine("4. " + LakeText.GetOptionText(stage, 4));

        int choice = GameUtils.GetValidInput(1, 4);
        return LakeText.IsCorrectChoice(stage, choice);
    }
}