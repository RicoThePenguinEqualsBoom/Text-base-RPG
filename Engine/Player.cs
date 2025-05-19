namespace Engine
{
    public class Player(int currentHP, int maxHP, int gold, int exP, int lvl, string name,
            string description) : LivingCreatures(currentHP, maxHP, name, description)
    {
        public int Gold { get; set; } = gold;
        public int ExP { get; set; } = exP;
        public int Lvl { get; set; } = lvl;
        public Locations CurrentLocation { get; set; }
        public List<InventoryItems> Inventory { get; set; } = [];
        public List<PlayerQuests> Quests { get; set; } = [];

        public bool HasRequiredItemToEnter(Locations location)
        {
            if(location.ItemRequiredToEnter == null)
            {
                return true;
            }

            foreach(InventoryItems ii in Inventory)
            {
                if(ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasQuest(Quests quest)
        {
            foreach(PlayerQuests pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    return true;
                }
            }

            return false;   
        }

        public bool CompletedQuest(Quests quest)
        {
            foreach(PlayerQuests pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    return pq.IsCompleted;
                }
            }

            return false;
        }

        public bool HasQuestItems(Quests quest)
        {
            foreach(QuestCompletionItems qci in quest.QuestCompletionItems)
            {
                bool itemInInventory = false;

                foreach(InventoryItems ii in Inventory)
                {
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        itemInInventory = true;

                        if(ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }

                if(!itemInInventory)
                {
                    return false;
                }
            }

            return true;
        }

        public void RemoveQuestItems(Quests quest)
        {
            foreach(QuestCompletionItems qci in quest.QuestCompletionItems)
            {
                foreach(InventoryItems ii in Inventory)
                {
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Items item)
        {
            foreach(InventoryItems ii in Inventory)
            {
                if(ii.Details.ID == item.ID)
                {
                    ++ii.Quantity;

                    return;
                }
            }

            Inventory.Add(new InventoryItems(item, 1));
        }

        public void QuestCompleted(Quests quest)
        {
            foreach(PlayerQuests pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    pq.IsCompleted = true;

                    return;
                }
            }
        }
    }
}
