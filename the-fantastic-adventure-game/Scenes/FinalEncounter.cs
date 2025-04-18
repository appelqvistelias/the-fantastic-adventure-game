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
        bool defenseIncreased = false;
        bool damageIncreased = false;

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();
            Console.WriteLine($"{player.Name}'s Health: {player.Health}");
            Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");

            Console.WriteLine("\n1. Attack! Strike with all your fury!");
            if (!defenseIncreased) Console.WriteLine("2. Call upon the might of the Aegis of the Shattered Sun and the aquatic powers of the Panoply of the Drowned King!");
            if (!damageIncreased) Console.WriteLine("3. Use the Mystical Forest Crystal Crown to fill your soul with the fury of nature and the dark powers of the Shadowfang Blade!");

            int choice = GameUtils.GetValidInput(1, 3);

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
            else if (choice == 2 && !defenseIncreased)
            {
                player.Defense += 15;
                defenseIncreased = true;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nYou become a bulwark of might!");
                Console.ResetColor();
            }
            else if (choice == 3 && !damageIncreased)
            {
                player.AttackDamage += 15;
                damageIncreased = true;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYour strikes thunder with the might of the forests and darkness!");
                Console.ResetColor();
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.Clear();
        if (player.Health > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have defeated the Dark Warden!");
            Console.WriteLine("\nThe shadowy figure collapses to the ground, its dark energy dissipating into the air.");
            Console.WriteLine("The arena falls silent, as if the world itself is holding its breath.");
            Console.WriteLine("For a moment, it seems as though the very fabric of reality is unraveling.");
            Console.WriteLine("\nWith a final, victorious cry, you raise your weapon high. The light from your shield shines brighter than ever before.");
            Console.WriteLine("You have overcome your greatest challenge, and the darkness that threatened the land has been banished.");
            Console.WriteLine("\nThe cheers of unseen voices echo in your ears, and the air is filled with the sweet scent of victory.");
            Console.WriteLine("You have proven yourself, the true hero, worthy of the title... and the world is saved.");
            Console.WriteLine("\nPress any key to continue and leave your belongings behind...");
            Console.ResetColor();
            Console.ReadKey();
            GameUtils.ClearInventory();
            Console.ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have been defeated. The darkness consumes you...");
            Console.WriteLine("\nThe world around you begins to fade, the arena dissolving into shadows.");
            Console.WriteLine("Your body feels heavy, as though the very essence of life is being drained from you.");
            Console.WriteLine("The Dark Warden's cold laughter echoes in your ears, the sound reverberating through your very soul.");
            Console.WriteLine("\nAs your vision blurs, you see a fleeting glimmer of light in the distance — hope, a promise of another chance.");
            Console.WriteLine("But the shadows tighten their grip, and you can feel your strength slipping away.");
            Console.WriteLine("\nJust as all seems lost, a voice calls out to you, soft yet strong.");
            Console.WriteLine("'This is not the end... it is only the beginning.'");
            Console.WriteLine("The darkness begins to lift, and your spirit is pulled back from the brink.");
            Console.WriteLine("\nWith a deep breath, you awaken once more, reborn, ready to face the challenge again.");
            Console.WriteLine("Your heart beats with renewed determination — the fight is not over yet. You will rise again.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
