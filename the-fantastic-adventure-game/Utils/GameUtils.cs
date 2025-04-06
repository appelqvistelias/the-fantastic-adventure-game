namespace the_fantastic_adventure_game.Utils
{
    public static class GameUtils
    {
        public static void ShowInvalidChoice()
        {
            Console.WriteLine("Invalid choice, please try again.");
        }

        public static void ShowExitMessage()
        {
            Console.WriteLine("Thank you for playing The Fantastic Adventure Game. Goodbye!");
        }

        public static int GetValidInput(int min, int max)
        {
            int choice;
            bool valid = false;

            do
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= min && choice <= max)
                {
                    valid = true;
                }
                else
                {
                    ShowInvalidChoice();
                }
            } while (!valid);

            return choice;
        }
    }
}