namespace Engine
{
    public class Quests
    {
        public int ID { get; set; } 
        public int RewardExP { get; set; } 
        public int RewardGold { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public Items RewardItems { get; set; }
        public List<QuestCompletionItems> QuestCompletionItems { get; set; } = [];

        public Quests() { }

        public Quests(int id, int rewardExP, int rewardGold, string name, string description)
        {
            ID = id;
            RewardExP = rewardExP;
            RewardGold = rewardGold;
            Name = name;
            Description = description;
        }
    }
}
