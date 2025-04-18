namespace the_fantastic_adventure_game.SceneTextContent;

public static class VillageText
{
    public static string Intro => "You enter the quiet village of Eldermoor. The air is thick with mystery, and each path seems to test your fate.";

    public static string Death => "A shadowy figure materializes out of thin air and drives a pitch-black dagger into your heart. You fall to the ground, your life slipping away instantly.";

    public static string Reward => "You survived all the trials in the village and discovered Aegis of the Shattered Sun! It hums with ancient power.";

    private static readonly Dictionary<int, string> ScenarioDescriptions = new()
    {
        { 1, "You reach the town square. A large statue stands in the center, and villagers are whispering about a shadow seen last night." },
        { 2, "You walk down a narrow street and encounter a mysterious old woman sitting by the side. She beckons you over." },
        { 3, "You approach a dilapidated house. The door creaks open on its own, and you feel a chill in the air." },
        { 4, "You find yourself at the edge of a dark forest. Strange lights flicker between the trees, as if guiding you deeper." },
        { 5, "You come across a well in the middle of the village. The water inside seems unusually dark, and something glimmers at the bottom." }
    };

    private static readonly Dictionary<(int, int), string> OptionTexts = new()
    {
        { (1, 1), "Inspect the statue closely" },
        { (1, 2), "Ask the villagers about the shadow" },
        { (1, 3), "Climb onto a rooftop to get a better view" },
        { (1, 4), "Follow a trail of black feathers into an alley" }, // Correct one

        { (2, 1), "Talk to the old woman" },
        { (2, 2), "Ignore her and continue down the street" }, // Correct one
        { (2, 3), "Ask the old woman about the shadow" },
        { (2, 4), "Offer her a coin for information" },

        { (3, 1), "Enter the house cautiously" }, 
        { (3, 2), "Knock on the door to ask if anyone is home" },
        { (3, 3), "Wait outside and listen for any strange noises" },
        { (3, 4), "Leave the house and head back" }, // Correct one

        { (4, 1), "Walk into the forest and follow the lights" },
        { (4, 2), "Ignore the lights and turn back" },
        { (4, 3), "Shout into the forest to see if anyone responds" },
        { (4, 4), "Follow the lights but stay at the edge of the trees" }, // Correct one

        { (5, 1), "Look into the well to see what is at the bottom" },
        { (5, 2), "Throw a stone into the well to see if anything happens" },
        { (5, 3), "Reach into the well to grab whatever is at the bottom" }, // Correct one
        { (5, 4), "Leave the well and walk away" }
    };

    private static readonly Dictionary<int, int> CorrectChoices = new()
    {
        { 1, 4 },
        { 2, 2 },
        { 3, 4 },
        { 4, 4 },
        { 5, 3 }
    };

    public static string GetScenarioText(int stage)
    {
        return ScenarioDescriptions.ContainsKey(stage)
            ? ScenarioDescriptions[stage]
            : "An unknown challenge awaits you.";
    }

    public static string GetOptionText(int stage, int option)
    {
        return OptionTexts.ContainsKey((stage, option))
            ? OptionTexts[(stage, option)]
            : "Unclear choice...";
    }

    public static bool IsCorrectChoice(int stage, int choice)
    {
        return CorrectChoices.ContainsKey(stage) && CorrectChoices[stage] == choice;
    }
}

