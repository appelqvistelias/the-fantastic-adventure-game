namespace the_fantastic_adventure_game.SceneTextContent;

public class CaveText
{
    public static string Intro => "You descend into the forgotten Caverns of Murmurdeep, seeking the fabled Crystal of Echoes. Ancient runes speak of five trials hidden in the depths, each testing your will and wit. The air grows colder as dim crystals light the way, and distant echoes hint you're not alone.";

    public static string Death => "A deep rumble precedes the cave floor giving way beneath you. You fall into a chasm, the darkness swallowing your scream. The cave claims another soul. Your journey ends here.";

    public static string Reward => "Having conquered all five trials of Murmurdeep, you enter a vast chamber where the Shadowfang Blade hovers above a massive rock formation, humming with ancient power. The artifact is yours – a reward for your courage and cunning.";

    private static readonly Dictionary<int, string> ScenarioDescriptions = new()
    {
        { 1, "At the cave entrance, you find a chamber ringed with towering crystal pillars. Strange hums resonate from each one, vibrating the air. This is the Echo Nexus, the first trial of Murmurdeep." },
        
        { 2, "Deeper inside, a narrow passage opens into a cavern lit by glowing fungi and a stone statue of a blindfolded sentinel. Its arms are outstretched as if expecting an offering. The second trial begins here." },
        
        { 3, "The path winds downward to an underground lake. The water is perfectly still, reflecting the cavern ceiling like glass. Faint whispers drift across the surface. This is the Whispering Mirror – your third trial." },
        
        { 4, "A crawlspace leads to a chamber filled with stone spires, each etched with symbols and names worn away by time. In the center lies a rusted brazier, faintly warm. The fourth trial lies hidden in memory and fire." },
        
        { 5, "At last, you reach a sealed chamber where an ancient altar stands beneath a ceiling of jagged stalactites. A skeletal figure draped in tattered robes kneels before it, unmoving. The fifth and final trial awaits your judgment." }
    };

    private static readonly Dictionary<(int, int), string> OptionTexts = new()
    {
        { (1, 1), "Strike one of the crystal pillars to test its resonance" },
        { (1, 2), "Step into the center of the Nexus and shout to awaken the cave" },
        { (1, 3), "Listen carefully to the humming crystals to discern a melody" },
        { (1, 4), "Carve your name into one of the crystal bases for luck" },

        { (2, 1), "Attempt to remove the blindfold from the sentinel statue" },
        { (2, 2), "Place your hand in the statue’s open palm to prove your intent" },
        { (2, 3), "Speak to the statue, requesting safe passage through the cave" },
        { (2, 4), "Leave a coin or trinket as an offering at its feet" },

        { (3, 1), "Drink from the still water to absorb the whispers" },
        { (3, 2), "Throw a stone into the lake to disrupt the silence" },
        { (3, 3), "Watch the reflections closely and follow where they shift" },
        { (3, 4), "Swim across to the opposite bank, ignoring the whispers" },

        { (4, 1), "Light the brazier with a piece of your own cloth" },
        { (4, 2), "Examine the symbols on the spires without disturbing anything" },
        { (4, 3), "Knock over one of the spires to uncover what's beneath" },
        { (4, 4), "Take ash from the brazier and mark your forehead with it" },

        { (5, 1), "Kneel beside the skeleton and whisper a respectful prayer" },
        { (5, 2), "Inspect the altar for hidden compartments or relics" },
        { (5, 3), "Remove the robes from the skeleton to examine them" },
        { (5, 4), "Challenge the spirit of the fallen to prove your worth" }
    };

    private static readonly Dictionary<int, int> CorrectChoices = new()
    {
        { 1, 4 },
        { 2, 3 },
        { 3, 3 },
        { 4, 1 },
        { 5, 1 }
    };

    public static string GetScenarioText(int stage)
    {
        return ScenarioDescriptions.ContainsKey(stage)
            ? ScenarioDescriptions[stage]
            : "A dark, unknown tunnel lies ahead in Murmurdeep.";
    }

    public static string GetOptionText(int stage, int option)
    {
        return OptionTexts.ContainsKey((stage, option))
            ? OptionTexts[(stage, option)]
            : "The cave offers no clear choice in this silence...";
    }

    public static bool IsCorrectChoice(int stage, int choice)
    {
        return CorrectChoices.ContainsKey(stage) && CorrectChoices[stage] == choice;
    }
}
