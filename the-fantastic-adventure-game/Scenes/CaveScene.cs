using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class CaveScene
{
    public static bool Play()
    {
        return GameUtils.PlayScene(
            CaveText.Intro,
            CaveText.Death,
            CaveText.Reward,
            CaveText.GetScenarioText,
            CaveText.GetOptionText,
            CaveText.IsCorrectChoice,
            new Item(
                "Crystal of Echoes",
                "An ancient artifact radiating the power of Murmurdeep Caverns."
            ),
            5 // Number of stages
        );
    }
}