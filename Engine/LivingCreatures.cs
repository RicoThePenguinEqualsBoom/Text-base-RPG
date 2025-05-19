namespace Engine
{
    public class LivingCreatures(int currentHP, int maxHP, string name, string description)
    {
        public int CurrentHP { get; set; } = currentHP;
        public int MaxHP { get; set; } = maxHP;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
    }
}
