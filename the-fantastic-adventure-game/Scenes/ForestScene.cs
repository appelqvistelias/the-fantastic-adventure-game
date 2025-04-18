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
                "Mystical Forest Crystal Crown",
                "A shimmering crown woven from ancient forest crystals, it channels the raw, untamed magic of the woods, granting its wearer control over nature’s forces and communion with the spirits of the forest."
            ),
            5
        );
    }
}