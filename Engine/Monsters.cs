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
        public int RewardExP { get; set; }
        public List<LootItems> LootTable { get; set; }

        public Monsters() : base(0, 0, "", "") { }

        public Monsters(int currentHP, int maxHP, int id, int maxDamage, int rewardExP, string name,
            string description) : base(currentHP, maxHP, name, description)
        {
            ID = id;
            MaxDamage = maxDamage;
            RewardExP = rewardExP;
            LootTable = [];
        }
    }
}
