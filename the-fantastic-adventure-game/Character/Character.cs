namespace the_fantastic_adventure_game.Character;

public class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public int AttackDamage { get; set; }
    public int Defense { get; set; }

    public Character(string name, int health, int attackDamage, int defense)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
        Defense = defense;
    }

    public void TakeDamage(int damage)
    {
        int finalDamage = Math.Max(damage - Defense, 0);
        Health -= finalDamage;
        Console.WriteLine($"{Name} takes {finalDamage} damage. Remaining health: {Health}");
    }

    public int Attack()
    {
        Random rng = new Random();
        double multiplier = rng.NextDouble() * 0.4 + 0.8;
        int finalDamage = (int)(AttackDamage * multiplier);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Name} attacks for {finalDamage} damage!");

        if (multiplier >= 1.15)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" CRITICAL HIT!");
        }

        Console.ResetColor();
        Console.WriteLine();
        return finalDamage;
    }
}