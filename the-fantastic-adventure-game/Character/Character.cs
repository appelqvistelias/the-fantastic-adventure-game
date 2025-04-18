namespace the_fantastic_adventure_game.Character;

public class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public int AttackDamage { get; }
    public int Defense { get; }

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
        return AttackDamage;
    }
}