using the_fantastic_adventure_game.Text;
using the_fantastic_adventure_game.Utils;
using the_fantastic_adventure_game.Scenes;

namespace the_fantastic_adventure_game.Scene;

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
                    GameUtils.ShowInventory();
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                    break;
                case "3":
                    GameUtils.ClearInventory();
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                    break;
                case "4":
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
        bool selecting = true;

        while (selecting)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nChoose a location to explore:");
            Console.WriteLine("1. The Village of Eldermoor");
            Console.WriteLine("2. The Dark Forest of Shadow Wood");
            Console.WriteLine("3. Murmurdeep, the Mysterious Cave");
            Console.WriteLine("4. The Murky Lake of Somberveil");
            Console.WriteLine("5. ???");
            Console.WriteLine("6. Return to Main Menu");

            int selection = GameUtils.GetValidInput(1, 6);

            switch (selection)
            {
                case 1:
                    if (GameUtils.HasItem("Aegis of the Shattered Sun"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou’ve already completed The Village of Eldermoor.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to choose another location.");
                        Console.ReadKey();
                    }
                    else
                    {
                        VillageScene.Play();
                        selecting = false;
                    }

                    break;

                case 2:
                    if (GameUtils.HasItem("Mystical Forest Crystal Crown"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou’ve already completed The Dark Forest of Shadow Wood.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to choose another location.");
                        Console.ReadKey();
                    }
                    else
                    {
                        ForestScene.Play();
                        selecting = false;
                    }

                    break;

                case 3:
                    if (GameUtils.HasItem("Shadowfang Blade"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou’ve already completed Murmurdeep Caverns.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to choose another location.");
                        Console.ReadKey();
                    }
                    else
                    {
                        CaveScene.Play();
                        selecting = false;
                    }

                    break;

                case 4:
                    if (GameUtils.HasItem("Panoply of the Drowned King"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou’ve already completed The Murky Lake of Somberveil.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to choose another location.");
                        Console.ReadKey();
                    }
                    else
                    {
                        LakeScene.Play();
                        selecting = false;
                    }

                    break;
                
                case 5:
                    if (GameUtils.HasItem("Aegis of the Shattered Sun") &&
                        GameUtils.HasItem("Mystical Forest Crystal Crown") &&
                        GameUtils.HasItem("Shadowfang Blade") &&
                        GameUtils.HasItem("Panoply of the Drowned King"))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nYou feel a strange pull... something greater awaits.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to give into the irresistible pull");
                        Console.ReadKey();
                        FinalEncounter.Play();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nNothing happens. Perhaps you're not ready yet...");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to choose another location.");
                        Console.ReadKey();
                    }
                    break;

                case 6:
                    selecting = false;
                    break;
            }
        }
    }
}