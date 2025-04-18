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
                "Shadowfang Blade",
                "A cursed weapon forged from the heart of a dying star, its obsidian edge thirsts for blood, shrouded in an eerie darkness that drains the life of those it strikes."
            ),
            5
        );
    }
}