using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.SceneTextContent;
using the_fantastic_adventure_game.Items;

namespace the_fantastic_adventure_game.Scenes;

public class VillageScene
{ 
    public static bool Play()
    {
        return GameUtils.PlayScene(
            VillageText.Intro,
            VillageText.Death,
            VillageText.Reward,
            VillageText.GetScenarioText,
            VillageText.GetOptionText,
            VillageText.IsCorrectChoice,
            new Item(
                "Amulet of Insight",
                "An ancient artifact radiating the power of Eldermoors ancestral memories."
            ),
            5
        );
    }
}
