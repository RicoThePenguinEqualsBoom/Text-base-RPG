namespace Engine
{
    public class Player(int currentHitPoints, int maxHitPoints, int gold, int experiencePoints, int level, string name,
            string description) : LivingCreatures(currentHitPoints, maxHitPoints, name, description)
    {
        public int Gold { get; set; } = gold;
        public int ExperiencePoints { get; set; } = experiencePoints;
        public int Level { get; set; } = level;
        public List<InventoryItems> Inventory { get; set; } = [];
        public List<PlayerQuests> Quests { get; set; } = [];
    }
}
