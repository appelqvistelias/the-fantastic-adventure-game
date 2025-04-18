namespace the_fantastic_adventure_game.SceneTextContent;

public class LakeText
{
    public static string Intro => "You arrive at the shores of Lake Somberveil, its glassy surface undisturbed and impossibly still. Legends say an ancient relic lies beneath its depths, protected by five sacred trials. Fog clings to the water, and unseen ripples suggest you're being watched.";

    public static string Death => "A sudden chill washes over you as the lake swells unnaturally. From its depths, something massive and unseen pulls you below. Darkness fills your lungs. The silence of the deep welcomes another soul. Your journey ends here.";

    public static string Reward => "You stand at the heart of a hidden islet, the fog lifting to reveal a pedestal where the Panoply of the Drowned King rests. It pulses with aquatic energy, resonating with every drop of water around you. You have claimed the lake’s long-lost power.";

    private static readonly Dictionary<int, string> ScenarioDescriptions = new()
    {
        { 1, "At the lake's edge, you find a ring of stones partially submerged, each engraved with wave-like runes. As the wind brushes the water, faint melodies drift across the surface. This is the Ring of Reflection, the first trial of Lake Somberveil." },

        { 2, "Wading to a small sandbar, you discover a weeping willow growing impossibly from its center. Beneath its branches sits a bowl filled with shimmering lakewater. This sacred spot is known as the Willow's Oath, second of the lake’s trials." },

        { 3, "You journey along a narrow wooden causeway that leads to a floating platform. A choir of frogs and insects falls silent as you step forward. In the middle lies a weathered mask carved from driftwood. Trial three awaits in stillness and sound." },

        { 4, "Beyond the platform, a fogbank parts to reveal a boat docked at a forgotten pier. A hooded figure slumbers at the stern, clutching an oar of bone. The fourth trial takes place on open water, under silent stars." },

        { 5, "The boat carries you to an underwater cave, illuminated by glowing plankton. A mural spans the chamber wall, depicting the rise and fall of a forgotten kingdom. In the center lies an empty shell-shaped throne. The final trial begins beneath the waves." }
    };

    private static readonly Dictionary<(int, int), string> OptionTexts = new()
    {
        { (1, 1), "Step into the water and touch one of the rune stones" },
        { (1, 2), "Sit by the stones and mimic the melody carried by the wind" }, // Correct one
        { (1, 3), "Cast a stone into the middle of the ring to test the water's reaction" },
        { (1, 4), "Walk around the ring three times, whispering your name each lap" },

        { (2, 1), "Drink from the bowl beneath the willow tree" },
        { (2, 2), "Kneel and speak your name into the tree’s reflection" },
        { (2, 3), "Place a token or keepsake into the water-filled bowl" }, // Correct one
        { (2, 4), "Snap a branch from the willow and keep it for protection" },

        { (3, 1), "Wear the driftwood mask to take on the lake’s identity" },
        { (3, 2), "Clap loudly to break the silence and test the acoustics" },
        { (3, 3), "Sit in silence and observe the lake’s surface closely" }, // Correct one
        { (3, 4), "Throw the mask into the lake as an offering" },

        { (4, 1), "Wake the hooded figure and ask for safe passage" },
        { (4, 2), "Quietly sit in the boat and wait for it to begin moving" }, // Correct one
        { (4, 3), "Attempt to steer the boat using the bone oar yourself" },
        { (4, 4), "Sing an old lake shanty to summon ancient guidance" },

        { (5, 1), "Place your hand on the mural to relive its history" },
        { (5, 2), "Sit in the shell throne with reverence and stillness" }, // Correct one
        { (5, 3), "Search the cave floor for hidden relics or scrolls" },
        { (5, 4), "Speak aloud the kingdom’s name if you remember it from the mural" }
    };

    private static readonly Dictionary<int, int> CorrectChoices = new()
    {
        { 1, 2 },
        { 2, 3 },
        { 3, 3 },
        { 4, 2 },
        { 5, 2 }
    };

    public static string GetScenarioText(int stage)
    {
        return ScenarioDescriptions.ContainsKey(stage)
            ? ScenarioDescriptions[stage]
            : "The mists of Lake Somberveil conceal what lies ahead.";
    }

    public static string GetOptionText(int stage, int option)
    {
        return OptionTexts.ContainsKey((stage, option))
            ? OptionTexts[(stage, option)]
            : "The lake offers no clear path forward...";
    }

    public static bool IsCorrectChoice(int stage, int choice)
    {
        return CorrectChoices.ContainsKey(stage) && CorrectChoices[stage] == choice;
    }
}