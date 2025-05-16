namespace Engine
{
    public class LivingCreatures(int currentHitPoints, int maxHitPoints, string name, string description)
    {
        public int CurrentHitPoints { get; set; } = currentHitPoints;
        public int MaxHitPoints { get; set; } = maxHitPoints;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
    }
}
