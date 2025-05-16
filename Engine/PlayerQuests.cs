namespace Engine
{
    public class PlayerQuests(Quests details)
    {
        public Quests Details { get; set; } = details;
        public bool IsCompleted { get; set; } = false;
    }
}
