namespace Engine
{
    public class Quests(int id, int rewardExP, int rewardGold, string name, string description)
    {
        public int ID { get; set; } = id;
        public int RewardExP { get; set; } = rewardExP;
        public int RewardGold { get; set; } = rewardGold;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public Items RewardItems { get; set; }
        public List<QuestCompletionItems> QuestCompletionItems { get; set; } = [];
    }
}
