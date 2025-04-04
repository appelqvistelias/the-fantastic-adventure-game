using System;
using TextAdventure.Text;
using TextAdventure.Utils;

namespace TextAdventure.Scene
{
    public class StartScene
    {
        private StartText startText = new StartText();

        public void StartGame()
        {
            startText.ShowIntro();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                startText.ShowBeginning();
                // Add transition to next location
            }
            else if (choice == "2")
            {
                GameUtils.ShowExitMessage();
                Environment.Exit(0);
            }
            else
            {
                GameUtils.ShowInvalidChoice();
                StartGame(); // Restart the game start, change to reverse later
            }
        }
    }
}