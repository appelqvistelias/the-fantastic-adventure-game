namespace the_fantastic_adventure_game.SceneTextContent;

public class ForestText
{
    public static string Intro => "You step into the ancient forest of Shadow Wood, seeking the legendary Forest Crystal. Ancient texts speak of five trials you must overcome to claim this powerful artifact. The dense canopy blocks most sunlight, and whispers seem to follow your every footstep.";

    public static string Death => "The shadows between the trees suddenly coalesce, forming a monstrous shape that lunges at you. Your scream echoes briefly before being swallowed by the silence of the forest. Your quest ends here.";

    public static string Reward => "Having passed all five trials of Shadow Wood Forest, the trees part to reveal a small pedestal. The mystical Forest Crystal Crown rises from it, pulsing with emerald energy that resonates with the life of the woods. You've earned its power!";

    private static readonly Dictionary<int, string> ScenarioDescriptions = new()
    {
        { 1, "At the forest entrance, you come across a clearing with a circle of ancient standing stones. Strange symbols are carved into each stone, and moonlight filters through the trees to illuminate them. According to legend, this is the Guardian's Gate, the first trial of Shadow Wood." },
        
        { 2, "Following a path revealed by the activated symbols, you arrive at an enormous, hollow tree. Local folklore calls this the Whispering Elder. Its bark seems to shift and move when you're not looking directly at it, and soft humming emanates from inside. This must be the second trial." },
        
        { 3, "The Elder's guidance leads you deeper into the forest where you discover a small brook with unnaturally still, black water - the infamous Mirror Stream. Floating on the surface are luminescent flowers that seem to move with purpose. The third trial awaits your decision." },
        
        { 4, "After following the flowers' path, the forest opens to reveal a perfect ring of red mushrooms known as the Fae Circle. In the center sits an abandoned campsite, with embers still glowing despite appearing long deserted. The fourth trial tests your wisdom." },
        
        { 5, "The embers' light guided you through the darkness to a moss-covered shrine partially reclaimed by the forest. This is the ancient Shrine of Verdant Truth, the final guardian of the Forest Crystal. A weathered statue of a forest spirit stands in the center, its eyes seeming to follow your movements." }
    };

    private static readonly Dictionary<(int, int), string> OptionTexts = new()
    {
        { (1, 1), "Touch one of the symbols on the stones, trying to activate its magic" },
        { (1, 2), "Walk to the center of the stone circle to harness its power" },
        { (1, 3), "Study the symbols from a distance, looking for patterns in their arrangement" }, // Correct one
        { (1, 4), "Take a small piece of stone as a souvenir to help on your journey" },

        { (2, 1), "Enter the hollow tree to investigate the source of the humming" },
        { (2, 2), "Place your ear against the tree to better understand the whispers" },
        { (2, 3), "Call out to whatever might be inside the tree, demanding passage" },
        { (2, 4), "Leave an offering of food at the base of the tree as a sign of respect" }, // Correct one

        { (3, 1), "Drink from the black water to gain the stream's knowledge" },
        { (3, 2), "Pick one of the luminescent flowers to light your way forward" },
        { (3, 3), "Observe and follow the direction the flowers are drifting" }, // Correct one
        { (3, 4), "Wade across the brook to the other side, taking the direct route" },

        { (4, 1), "Step inside the mushroom ring to commune with fae spirits" },
        { (4, 2), "Carefully examine the embers without disturbing their arrangement" }, // Correct one
        { (4, 3), "Kick the embers to dispel any enchantment upon the campsite" },
        { (4, 4), "Take one of the mushrooms to use as protection against forest magic" },

        { (5, 1), "Kneel before the statue in respect, acknowledging the forest's wisdom" }, // Correct one
        { (5, 2), "Clean the moss off the statue to restore its former glory" },
        { (5, 3), "Search around the shrine for hidden clues or treasures" },
        { (5, 4), "Assert your dominance by staring back into the statue's eyes" }
    };

    private static readonly Dictionary<int, int> CorrectChoices = new()
    {
        { 1, 3 },
        { 2, 4 },
        { 3, 3 },
        { 4, 2 },
        { 5, 1 }
    };

    public static string GetScenarioText(int stage)
    {
        return ScenarioDescriptions.ContainsKey(stage)
            ? ScenarioDescriptions[stage]
            : "An unknown path lies before you in the darkness of Shadowwood.";
    }

    public static string GetOptionText(int stage, int option)
    {
        return OptionTexts.ContainsKey((stage, option))
            ? OptionTexts[(stage, option)]
            : "The way forward is unclear in this ancient forest...";
    }

    public static bool IsCorrectChoice(int stage, int choice)
    {
        return CorrectChoices.ContainsKey(stage) && CorrectChoices[stage] == choice;
    }
}