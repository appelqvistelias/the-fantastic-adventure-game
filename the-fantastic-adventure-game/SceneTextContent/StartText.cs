namespace the_fantastic_adventure_game.Text
{
    public class StartText
    {
        public void ShowIntro()
        {
            Console.Clear();
            Console.WriteLine("Welcome to The Fantastic Adventure Game!");
            Console.WriteLine("You are about to embark on a fantastic adventure!");
            Console.WriteLine("1. Start the adventure");
            Console.WriteLine("2. Exit the game");
        }

        public void ShowBeginning()
        {
            Console.Clear();
            Console.WriteLine("Your journey begins...");
            Console.WriteLine("Before you lie multiple paths, each filled with mystery and danger.");
        }
    }
}