using Engine;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private Monsters _currentMonster;

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1, "name", "You are you, nothing more, nothing less.");
            MoveTo(World.LocationById(World.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItems(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));

            lblHP.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExP.Text = _player.ExP.ToString();
            lblLvl.Text = _player.Lvl.ToString();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void MoveTo(Locations newLocation)
        {
            if(!_player.HasRequiredItemToEnter(newLocation))
            {
                rtbMessages.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this " +
                    "location." + Environment.NewLine;
                return;
            }

            _player.CurrentLocation = newLocation;

            btnNorth.Visible = newLocation.LocationToNorth != null;
            btnEast.Visible = newLocation.LocationToEast != null;
            btnWest.Visible = newLocation.LocationToWest != null;
            btnSouth.Visible = newLocation.LocationToSouth != null;

            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            _player.CurrentHP= _player.MaxHP;

            lblHP.Text = _player.CurrentHP.ToString();

            if (newLocation.QuestsAvailableHere != null)
            {
                bool playerAlreadyHasQuest = _player.HasQuest(newLocation.QuestsAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedQuest(newLocation.QuestsAvailableHere);

                if (playerAlreadyHasQuest)
                {
                    if (!playerAlreadyCompletedQuest)
                    {
                        bool playerHasQuestItems = _player.HasQuestItems(newLocation.QuestsAvailableHere);

                        if (playerHasQuestItems)
                        {
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You completed the " + newLocation.QuestsAvailableHere.Name + " quest!" +
                                Environment.NewLine;

                            _player.RemoveQuestItems(newLocation.QuestsAvailableHere);

                            rtbMessages.Text += "You receive: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestsAvailableHere.RewardExP.ToString() +
                                " experience points" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestsAvailableHere.RewardGold.ToString() + " gold" +
                                Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestsAvailableHere.RewardItems.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.ExP+= newLocation.QuestsAvailableHere.RewardExP;
                            _player.Gold += newLocation.QuestsAvailableHere.RewardGold;

                            _player.AddItemToInventory(newLocation.QuestsAvailableHere.RewardItems);

                            _player.QuestCompleted(newLocation.QuestsAvailableHere);
                        }
                    }
                }
                else
                {
                    rtbMessages.Text += "You receive the " + newLocation.QuestsAvailableHere.Name + " quest!" +
                        Environment.NewLine;
                    rtbMessages.Text += newLocation.QuestsAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "To complete it, return with:" + Environment.NewLine;

                    foreach (QuestCompletionItems qci in newLocation.QuestsAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }

                    rtbMessages.Text += Environment.NewLine;

                    _player.Quests.Add(new PlayerQuests(newLocation.QuestsAvailableHere));
                }
            }

            if (newLocation.MonstersLivingHere != null)
            {
                rtbMessages.Text += "You see a " + newLocation.MonstersLivingHere.Name + Environment.NewLine;

                Monsters standardMonster = World.MonsterByID(newLocation.MonstersLivingHere.ID);

                _currentMonster = new Monsters(standardMonster.CurrentHP, standardMonster.MaxHP,
                    standardMonster.ID, standardMonster.MaxDamage, standardMonster.RewardExP,
                    standardMonster.Name, standardMonster.Description);

                foreach (LootItems lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                weaponBox.Visible = true;
                potionBox.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentMonster = null;

                weaponBox.Visible = false;
                potionBox.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
            }

            UpdateInventoryList();

            UpdateQuestList();

            UpdateWeaponList();

            UpdatePotionList();
        }

        private void UpdateInventoryList()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryItems ii in _player.Inventory)
            {
                if (ii.Quantity > 0)
                {
                    dgvInventory.Rows.Add([ii.Details.Name, ii.Quantity.ToString()]);
                }
            }
        }

        private void UpdateQuestList()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";

            dgvQuests.Rows.Clear();

            foreach (PlayerQuests pq in _player.Quests)
            {
                dgvQuests.Rows.Add([pq.Details.Name, pq.IsCompleted.ToString()]);
            }
        }

        private void UpdateWeaponList()
        {
            List<Weapons> weapons = [];

            foreach (InventoryItems ii in _player.Inventory)
            {
                if (ii.Details is Weapons weapon)
                {
                    if (ii.Quantity > 0)
                    {
                        weapons.Add(weapon);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                weaponBox.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                weaponBox.DataSource = weapons;
                weaponBox.DisplayMember = "Name";
                weaponBox.ValueMember = "ID";

                weaponBox.SelectedIndex = 0;
            }
        }

        private void UpdatePotionList()
        {
            List<HealingPotion> healingPotions = [];

            foreach (InventoryItems ii in _player.Inventory)
            {
                if (ii.Details is HealingPotion potion)
                {
                    if (ii.Quantity > 0)
                    {
                        healingPotions.Add(potion);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                potionBox.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                potionBox.DataSource = healingPotions;
                potionBox.DisplayMember = "Name";
                potionBox.ValueMember = "ID";

                potionBox.SelectedIndex = 0;
            }
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            Weapons currentWeapon = (Weapons)weaponBox.SelectedItem;

            int damageToMonster = RNG.NumberBetween(currentWeapon.MinDamage, currentWeapon.MaxDamage);

            _currentMonster.CurrentHP -= damageToMonster;

            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " +
                damageToMonster.ToString() + " damage." + Environment.NewLine;

            if(_currentMonster.CurrentHP <= 0)
            {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                _player.ExP += _currentMonster.RewardExP;
                rtbMessages.Text += "You received " + _currentMonster.RewardExP.ToString() +
                    " exp." + Environment.NewLine;

                List<InventoryItems> lootedItems = [];

                foreach(LootItems lootItem in _currentMonster.LootTable)
                {
                    if(RNG.NumberBetween(1, 100) <= lootItem.DropChance)
                    {
                        lootedItems.Add(new InventoryItems(lootItem.Details, 1));
                    }
                }

                if(lootedItems.Count == 0)
                {
                    foreach(LootItems lootItem in _currentMonster.LootTable)
                    {
                        if(lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItems(lootItem.Details, 1));
                        }
                    }
                }

                foreach(InventoryItems ii in lootedItems)
                {
                    _player.AddItemToInventory(ii.Details);

                    if(ii.Quantity == 1)
                    {
                        rtbMessages.Text += "You looted a " + ii.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You looted " + ii.Quantity.ToString() + " " +
                            ii.Details.NamePlural + Environment.NewLine;
                    }
                }

                lblHP.Text = _player.CurrentHP.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblExP.Text = _player.ExP.ToString();
                lblLvl.Text = _player.Lvl.ToString();

                UpdateInventoryList();
                UpdatePotionList();

                rtbMessages.Text += Environment.NewLine;

                MoveTo(_player.CurrentLocation);
            }
            else
            {
                int damageToPlayer = RNG.NumberBetween(1, _currentMonster.MaxDamage);

                rtbMessages.Text += "The " + _currentMonster.Name + " did " +
                    damageToPlayer.ToString() + " damage." + Environment.NewLine;

                _player.CurrentHP -= damageToPlayer;

                lblHP.Text = _player.CurrentHP.ToString();

                if(_player.CurrentHP <= 0)
                {
                    rtbMessages.Text += "The " + _currentMonster.Name + " knocked you out." + Environment.NewLine;
                    MoveTo(World.LocationById(World.LOCATION_ID_HOME));
                    rtbMessages.Text += "A kind stranger must have brought you home." + Environment.NewLine;
                }
            }
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            HealingPotion potion = (HealingPotion)potionBox.SelectedItem;

            _player.CurrentHP += potion.AmountToHeal;

            if(_player.CurrentHP > _player.MaxHP)
            {
                _player.CurrentHP = _player.MaxHP;
            }

            foreach(InventoryItems ii in _player.Inventory)
            {
                if(ii.Details.ID == potion.ID)
                {
                    --ii.Quantity;
                    break;
                }
            }

            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            int damageToPlayer = RNG.NumberBetween(1, _currentMonster.MaxDamage);

            rtbMessages.Text += "The " + _currentMonster.Name + " did " +
                    damageToPlayer.ToString() + " damage." + Environment.NewLine;

            _player.CurrentHP -= damageToPlayer;

            lblHP.Text = _player.CurrentHP.ToString();

            if (_player.CurrentHP <= 0)
            {
                rtbMessages.Text += "The " + _currentMonster.Name + " knocked you out." + Environment.NewLine;
                MoveTo(World.LocationById(World.LOCATION_ID_HOME));
                rtbMessages.Text += "A kind stranger must have brought you home." + Environment.NewLine;
            }

            UpdateInventoryList();
            UpdatePotionList();
        }
    }
}
