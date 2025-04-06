using the_fantastic_adventure_game.Text;
using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.Scenes;
using the_fantastic_adventure_game.SceneTextContent;

namespace the_fantastic_adventure_game.Scene
{
    public class StartScene
    {
        private readonly StartText startText = new StartText();

        public void StartGame()
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                startText.ShowIntro();
                string? choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        startText.ShowBeginning();
                        SelectScene();
                        break;
                    case "2":
                        GameUtils.ShowExitMessage();
                        Environment.Exit(0);
                        break;
                    default:
                        GameUtils.ShowInvalidChoice();
                        break;
                }
            }
        }

        private void SelectScene()
        {
            Console.WriteLine("\nChoose a location to explore:");
            Console.WriteLine("1. The Village of Eldermoor");
            Console.WriteLine("2. The Dark Forest");
            Console.WriteLine("3. Mysterious Cave");

            int selection = GameUtils.GetValidInput(1, 3);

            switch (selection)
            {
                case 1:
                    VillageScene.Play();
                    break;
                case 2:
                    ForestScene.Play();
                    break;
                case 3:
                    Console.WriteLine("The Cave is still being discovered. Check back later!");
                    break;
            }
        }
    }
}