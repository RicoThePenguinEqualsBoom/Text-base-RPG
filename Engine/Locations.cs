namespace Engine
{
    public class Locations(int id, string name, string description, Items itemRequiredToEnter = null,
            Quests questsAvailableHere = null, Monsters monstersLivingHere = null)
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public Items ItemRequiredToEnter { get; set; } = itemRequiredToEnter;
        public Quests QuestsAvailableHere { get; set; } = questsAvailableHere;
        public Monsters MonstersLivingHere { get; set; } = monstersLivingHere;
        public Locations LocationToNorth { get; set; }
        public Locations LocationToSouth { get; set; }
        public Locations LocationToEast { get; set; }
        public Locations LocationToWest { get; set; }
    }
}
