﻿namespace Engine
{
    [Serializable]
    public class Player : LivingCreatures
    {
        public int Gold { get; set; }
        public int ExP { get; set; }
        public int Lvl => ((ExP / 100) + 1);
        public Locations CurrentLocation { get; set; }
        public List<InventoryItems> Inventory { get; set; } = [];
        public List<PlayerQuests> Quests { get; set; } = [];

        public Player() : base(0, 0, "", "") { }

        public Player(int currentHP, int maxHP, int gold, int exp, string name, string description)
            : base(currentHP, maxHP, name, description)
        {
            Gold = gold;
            ExP = exp;
        }

        // Create all the methods pertaining exclusively to the player
        public bool HasRequiredItemToEnter(Locations location)
        {
            if(location.ItemRequiredToEnter == null)
            {
                return true;
            }

            return Inventory.Exists(ii => ii.Details.ID == location.ItemRequiredToEnter.ID);
        }

        public bool HasQuest(Quests quest)
        {
            return Quests.Exists(pq => pq.Details.ID == quest.ID);   
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
                if(!Inventory.Exists(ii => ii.Details.ID == qci.Details.ID && ii.Quantity >= qci.Quantity))
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
                InventoryItems item = Inventory.SingleOrDefault(ii => ii.Details.ID == qci.Details.ID);
                if (item != null)
                {
                    item.Quantity -= qci.Quantity;
                }
            }
        }

        public void AddItemToInventory(Items addedItem)
        {
            InventoryItems item = Inventory.SingleOrDefault(ii => ii.Details.ID == addedItem.ID);

            if(item == null)
            {
                Inventory.Add(new InventoryItems(addedItem, 1));
            }
            else
            {
                ++item.Quantity;
            }
        }

        public void QuestCompleted(Quests quest)
        {
            PlayerQuests playerQuest = Quests.SingleOrDefault(pq => pq.Details.ID == quest.ID);
            if (playerQuest != null)
            {
                playerQuest.IsCompleted = true;
                playerQuest.State = "Completed";

                return;
            }
        }
    }
}
