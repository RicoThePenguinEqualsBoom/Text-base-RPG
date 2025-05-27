namespace Engine
{
    public class Locations
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Items ItemRequiredToEnter { get; set; }
        public Quests QuestsAvailableHere { get; set; }
        public Monsters MonstersLivingHere { get; set; }
        public Locations LocationToNorth { get; set; }
        public Locations LocationToSouth { get; set; }
        public Locations LocationToEast { get; set; }
        public Locations LocationToWest { get; set; }

        public Locations() { }

        public Locations(int id, string name, string description, Items itemRequiredToEnter = null,
            Quests questsAvailableHere = null, Monsters monstersLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestsAvailableHere = questsAvailableHere;
            MonstersLivingHere = monstersLivingHere;
        }
    }
}
