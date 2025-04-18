using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class ForestScene
{
    public static bool Play()
    {
        return GameUtils.PlayScene(
            ForestText.Intro,
            ForestText.Death,
            ForestText.Reward,
            ForestText.GetScenarioText,
            ForestText.GetOptionText,
            ForestText.IsCorrectChoice,
            new Item(
                "Mystical Forest Crystal",
                "An ancient artifact radiating the power of the Shadow Wood."
            ),
            5
        );
    }
}