namespace Engine
{
    public class PlayerQuests
    {
        public Quests Details { get; set; } 
        public bool IsCompleted { get; set; } 
        public string State { get; set; } 

        public PlayerQuests() { }

        public PlayerQuests(Quests details, bool isCompleted = false, string state = "In progress")
        {
            Details = details;
            IsCompleted = isCompleted;
            State = state;
        }
    }
}
