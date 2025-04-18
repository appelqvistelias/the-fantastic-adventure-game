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
                "Aegis of the Shattered Sun",
                "Forged from the remnants of a fallen celestial star, this shield gleams with an otherworldly radiance, imbuing its wielder with the power of light while offering protection against shadow and darkness, a relic of a forgotten age of gods."
            ),
            5
        );
    }
}
