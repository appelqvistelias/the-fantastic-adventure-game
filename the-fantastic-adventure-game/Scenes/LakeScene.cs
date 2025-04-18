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
                "Panoply of the Drowned King",
                "An ancient, cursed armor forged from the depths of a lost kingdom, granting its wearer dominion over water, but at the cost of being haunted by the tragic echoes of the drowned king."
            ),
            5
        );
    }
}