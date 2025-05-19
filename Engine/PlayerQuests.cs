namespace Engine
{
    public class PlayerQuests(Quests details)
    {
        public Quests Details { get; set; } = details;
        public bool IsCompleted { get; set; } = false;
        public string State { get; set; } = "In progress";
    }
}
