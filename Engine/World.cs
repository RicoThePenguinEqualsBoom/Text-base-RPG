namespace Engine
{
    public static class World
    {
        public static readonly List<Items> Items = [];
        public static readonly List<Monsters> Monsters = [];
        public static readonly List<Quests> Quests = [];
        public static readonly List<Locations> Locations = [];

        public const Items missingIt = null;
        public const Monsters missingMo = null;
        public const Quests missingQu = null;
        public const Locations missingLo = null;

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapons(ITEM_ID_RUSTY_SWORD, 2, 1, 5, "Rusty Sword", "Rusty Swords", "An old, rusty sword." +
                " No amount of work could restore it to its previous grandeur."));
            Items.Add(new Weapons(ITEM_ID_CLUB, 4, 3, 10, "Club", "Clubs", "A heavy wooden club. It feels comfortable to hold."));
            Items.Add(new Items(ITEM_ID_RAT_TAIL, 1, "Rat Tail", "Rat Tails", "A tail cut from a rat. Maybe the Inn can use" +
                " it for cheap meals."));
            Items.Add(new Items(ITEM_ID_PIECE_OF_FUR, 2, "Piece of fur", "Pieces of fur", "A piece of fur cut from a rat." +
                " The tailor could make it into some gloves."));
            Items.Add(new Items(ITEM_ID_SNAKE_FANG, 5, "Snake fang", "Snake fangs", "A fang from a snake. The venom" +
                " contained inside is useful in making concoctions."));
            Items.Add(new Items(ITEM_ID_SNAKESKIN, 3, "Snakeskin", "Snakeskins", "A piece of skin cut from a snake." +
                " The alchemist could make snake oil out of it."));
            Items.Add(new Items(ITEM_ID_SPIDER_FANG, 15, "Spider fang", "Spider fangs", "A fang from a giant spider." +
                " The venom contained inside is useful in making concoctions."));
            Items.Add(new Items(ITEM_ID_SPIDER_SILK, 6, "Spider silk", "Spider silks", "A strand of silk from a giant spider." +
                " The tailor needs all they can get."));
            Items.Add(new Items(ITEM_ID_ADVENTURER_PASS, 50, "Adventurer Pass", "Adventurer Passes", "A pass that" +
                " allows an individual to enter cities without paying an entrance fee."));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, 10, 5, "Healing potion", "Healing potions", "A potion" +
                " that heals cuts, scrapes and gouges."));
        }

        private static void PopulateMonsters()
        {
            Monsters rat = new(3, 3, MONSTER_ID_RAT, 5, 10, "Rat", "A, furry, rodent, pest." +
                " Not dangerous to the average armed person but very annoying.");
            rat.LootTable.Add(new LootItems(ItemByID(ITEM_ID_RAT_TAIL), 100, false));
            rat.LootTable.Add(new LootItems(ItemByID(ITEM_ID_PIECE_OF_FUR), 65, true));

            Monsters snake = new(3, 3, MONSTER_ID_SNAKE, 5, 10, "Snake", "A long, slithering, reptile. It likes to hide in" +
                " tall weeds and bushes. While poisonous, it isn't much of a threat on its own.");
            snake.LootTable.Add(new LootItems(ItemByID(ITEM_ID_SNAKE_FANG), 100, false));
            snake.LootTable.Add(new LootItems(ItemByID(ITEM_ID_SNAKESKIN), 65, true));

            Monsters giantSpider = new(10, 10, MONSTER_ID_GIANT_SPIDER, 5, 40, "Giant spider", "A spider the size of" +
                " a small child. Beware of getting ganged up on.");
            giantSpider.LootTable.Add(new LootItems(ItemByID(ITEM_ID_SPIDER_FANG), 100, true));
            giantSpider.LootTable.Add(new LootItems(ItemByID(ITEM_ID_SPIDER_SILK), 20, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quests clearAlchemistGarden = new(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, 20, 10, "Clear the alchemist's" +
                " garden", "Kill rats in the alchemist's garden. You will receive a healing potion" +
                " and 20 gold pieces as a reward.");

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItems(3, ItemByID(ITEM_ID_RAT_TAIL)));

            clearAlchemistGarden.RewardItems = ItemByID(ITEM_ID_HEALING_POTION);

            Quests clearFarmersField = new(QUEST_ID_CLEAR_FARMERS_FIELD, 20, 20, "Clear the farmer's field",
                "Kill snakes in the farmer's field. You will receive an adventurer's pass and" +
                " 20 gold pieces as a reward.");

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItems(3, ItemByID(ITEM_ID_SNAKE_FANG)));

            clearFarmersField.RewardItems = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            Locations home = new(LOCATION_ID_HOME, "Home", "This is the house you grew up in." +
                " You should really clean up sometime.");

            Locations townSquare = new(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain people busting.");

            Locations alchemistHut = new(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants" +
                " and herbs on the shelves.")
            {
                QuestsAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN)
            };

            Locations alchemistGarden = new(LOCATION_ID_ALCHEMIST_GARDEN, "Alchemist's garden", "Many unusual plants" +
                " grow here.")
            {
                MonstersLivingHere = MonsterByID(MONSTER_ID_RAT)
            };

            Locations farmhouse = new(LOCATION_ID_FARMHOUSE, "Farmhouse", " There is a small farmhouse," +
                " with a farmer in front.")
            {
                QuestsAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD)
            };

            Locations farmersField = new(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables sprouting.")
            {
                MonstersLivingHere = MonsterByID(MONSTER_ID_SNAKE)
            };

            Locations guardPost = new(LOCATION_ID_GUARD_POST, "Guard post", "A, large, tough-looking guard is standing " +
                "here. He looks bored.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Locations bridge = new(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a large river.");

            Locations spiderField = new(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering the surrounding" +
                " trees in this forest.")
            {
                MonstersLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER)
            };

            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistGarden;

            alchemistGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistGarden);
            Locations.Add(guardPost);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Items ItemByID(int id)
        {
            foreach(Items item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return missingIt;
        }

        public static Monsters MonsterByID(int id)
        {
            foreach(Monsters monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }

            return missingMo;
        }

        public static Quests QuestByID(int id)
        {
            foreach(Quests quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }
            return missingQu;
        }

        public static Locations LocationById(int id)
        {
            foreach(Locations location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }

            return missingLo;
        }
    }
}
