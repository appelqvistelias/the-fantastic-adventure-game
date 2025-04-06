namespace the_fantastic_adventure_game.SceneTextContent
{
    public static class VillageText
    {
        public static string Intro => "You enter the quiet village of Eldermoor. The air is thick with mystery, and each path seems to test your fate.";

        public static string Death => "You made the wrong choice and met your unfortunate end.";

        public static string Reward => "You survived all the trials in the village and discovered a glowing Amulet of Insight! It hums with ancient power.";

        // Scenario texts
        private static readonly Dictionary<int, string> ScenarioDescriptions = new() // Connecting stage (int) to string
        {
            { 1, "You reach the town square. A large statue stands in the center, and villagers are whispering about a shadow seen last night." },
            // Add more scenarios (2–5) here later
        };

        // Options for each scenario
        private static readonly Dictionary<(int, int), string> OptionTexts = new()
        {
            // Format: {(stage, option), "option text"}
            { (1, 1), "Inspect the statue closely" },
            { (1, 2), "Ask the villagers about the shadow" },
            { (1, 3), "Climb onto a rooftop to get a better view" },
            { (1, 4), "Follow a trail of black feathers into an alley" }, // Correct one
        };

        // Correct choices per stage
        private static readonly Dictionary<int, int> CorrectChoices = new()
        {
            { 1, 4 },
            // Add more correct answers here
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
}
