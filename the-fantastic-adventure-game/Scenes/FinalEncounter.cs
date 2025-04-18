using the_fantastic_adventure_game.Utils;

namespace the_fantastic_adventure_game.Scenes;

public class FinalEncounter
{
    public static void Play()
    {
        Console.WriteLine("You step into the dark and foreboding arena...");
        Console.WriteLine("A shadowy figure emerges from the mist. It is your final challenge!");

        the_fantastic_adventure_game.Character.Character player =
            new the_fantastic_adventure_game.Character.Character("Hero", 100, 25, 5);
        the_fantastic_adventure_game.Character.Character enemy =
            new the_fantastic_adventure_game.Character.Character("The Dark Warden", 150, 30, 10);

        StartCombat(player, enemy);
    }

    private static void StartCombat(the_fantastic_adventure_game.Character.Character player,
        the_fantastic_adventure_game.Character.Character enemy)
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();
            Console.WriteLine($"{player.Name}'s Health: {player.Health}");
            Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");

            Console.WriteLine("\nPress 1 to attack.");
            int choice = GameUtils.GetValidInput(1, 1);

            if (choice == 1)
            {
                int playerDamage = player.Attack();
                Console.WriteLine($"\nYou attack the enemy for {playerDamage} damage!");
                enemy.TakeDamage(playerDamage);

                if (enemy.Health <= 0) break;

                int enemyDamage = enemy.Attack();
                Console.WriteLine($"\nThe enemy strikes back for {enemyDamage} damage!");
                player.TakeDamage(enemyDamage);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.Clear();
        if (player.Health > 0)
        {
            Console.WriteLine("You have defeated the Dark Warden!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("You have been defeated. The darkness consumes you...");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

    }
}