namespace Engine
{
    public class Monsters : LivingCreatures
    {
        #region for future implementation
        /*  //To make exp less predictable
         * public int MinExperiencePoints { get; set; }
         * public int MaxExperiencePoints { get; set; }
         *  //To make the world feel more fleshed out
         * public string NamePlural { get; set; }*/
        #endregion

        public int ID { get; set; }
        public int MaxDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public List<LootItems> LootTable { get; set; }

        public Monsters(int currentHitPoints, int maxHitPoints, int id, int maxDamage, int rewardExperiencePoints, string name,
            string description) : base(currentHitPoints, maxHitPoints, name, description)
        {
            ID = id;
            MaxDamage = maxDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Name = name;
            LootTable = [];
        }
    }
}
