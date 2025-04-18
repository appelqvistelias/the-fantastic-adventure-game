namespace the_fantastic_adventure_game.Text
{
    public class StartText
    {
        public void ShowIntro()
        {
            Console.Clear();

            Console.WriteLine(@"
 __          __  _                            _                                  
 \ \        / / | |                          | |                                 
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___                            
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \                           
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |                          
  ___\/__\/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/                           
 |__   __| |              /\                       (_)                           
    | |  | |__   ___     /  \   _ __ ___   __ _ _____ _ __   __ _                
    | |  | '_ \ / _ \   / /\ \ | '_ ` _ \ / _` |_  / | '_ \ / _` |               
    | |  | | | |  __/  / ____ \| | | | | | (_| |/ /| | | | | (_| |               
    |_|  |_| |_|\___| /_/    \_\_| |_| |_|\__,_/___|_|_|_|_|\__, |               
     /\      | |               | |                   / ____| __/ |               
    /  \   __| |_   _____ _ __ | |_ _   _ _ __ ___  | |  __ |___/ _ __ ___   ___ 
   / /\ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \ | | |_ |/ _` | '_ ` _ \ / _ \
  / ____ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/ | |__| | (_| | | | | | |  __/
 /_/    \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|  \_____|\__,_|_| |_| |_|\___|
                                                                                 
");

            Console.WriteLine("You are about to embark on a fantastic adventure!");
            Console.WriteLine();
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