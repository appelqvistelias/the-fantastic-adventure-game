using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class LakeScene
{
    public static bool Play()
    {
        return GameUtils.PlayScene(
            LakeText.Intro,
            LakeText.Death,
            LakeText.Reward,
            LakeText.GetScenarioText,
            LakeText.GetOptionText,
            LakeText.IsCorrectChoice,
            new Item(
                "Relic of Tides",
                "An ancient artifact radiating the power of Lake Somberveil."
            ),
            5
        );
    }
}