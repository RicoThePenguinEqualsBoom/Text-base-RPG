namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHP = new Label();
            lblGold = new Label();
            lblExP = new Label();
            lblLvl = new Label();
            label5 = new Label();
            weaponBox = new ComboBox();
            potionBox = new ComboBox();
            btnUseWeapon = new Button();
            btnUsePotion = new Button();
            btnWest = new Button();
            btnEast = new Button();
            btnSouth = new Button();
            btnNorth = new Button();
            rtbLocation = new RichTextBox();
            rtbMessages = new RichTextBox();
            dgvInventory = new DataGridView();
            dgvQuests = new DataGridView();
            btnSave = new Button();
            btnReset = new Button();
            rdbtnOn = new RadioButton();
            rdbtnOff = new RadioButton();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Location = new Point(70, 19);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(0, 15);
            lblHP.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(70, 45);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 15);
            lblGold.TabIndex = 5;
            // 
            // lblExP
            // 
            lblExP.AutoSize = true;
            lblExP.Location = new Point(110, 73);
            lblExP.Name = "lblExP";
            lblExP.Size = new Size(0, 15);
            lblExP.TabIndex = 6;
            // 
            // lblLvl
            // 
            lblLvl.AutoSize = true;
            lblLvl.Location = new Point(110, 99);
            lblLvl.Name = "lblLvl";
            lblLvl.Size = new Size(0, 15);
            lblLvl.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(626, 552);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Select action";
            // 
            // weaponBox
            // 
            weaponBox.FormattingEnabled = true;
            weaponBox.Location = new Point(399, 580);
            weaponBox.Name = "weaponBox";
            weaponBox.Size = new Size(121, 23);
            weaponBox.TabIndex = 9;
            // 
            // potionBox
            // 
            potionBox.FormattingEnabled = true;
            potionBox.Location = new Point(399, 614);
            potionBox.Name = "potionBox";
            potionBox.Size = new Size(121, 23);
            potionBox.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.Location = new Point(629, 580);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(75, 23);
            btnUseWeapon.TabIndex = 11;
            btnUseWeapon.Text = "Use";
            btnUseWeapon.UseVisualStyleBackColor = true;
            btnUseWeapon.Click += btnUseWeapon_Click;
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(629, 614);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(75, 23);
            btnUsePotion.TabIndex = 12;
            btnUsePotion.Text = "Use";
            btnUsePotion.UseVisualStyleBackColor = true;
            btnUsePotion.Click += btnUsePotion_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(483, 467);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 23);
            btnWest.TabIndex = 13;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(644, 467);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 23);
            btnEast.TabIndex = 14;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(564, 497);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 23);
            btnSouth.TabIndex = 15;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(564, 443);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 23);
            btnNorth.TabIndex = 16;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // rtbLocation
            // 
            rtbLocation.Location = new Point(369, 10);
            rtbLocation.Name = "rtbLocation";
            rtbLocation.ReadOnly = true;
            rtbLocation.Size = new Size(360, 105);
            rtbLocation.TabIndex = 17;
            rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(369, 121);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(360, 295);
            rtbMessages.TabIndex = 18;
            rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventory.Enabled = false;
            dgvInventory.Location = new Point(12, 121);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.Size = new Size(312, 323);
            dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            dgvQuests.AllowUserToAddRows = false;
            dgvQuests.AllowUserToDeleteRows = false;
            dgvQuests.AllowUserToResizeRows = false;
            dgvQuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuests.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvQuests.Enabled = false;
            dgvQuests.Location = new Point(12, 450);
            dgvQuests.MultiSelect = false;
            dgvQuests.Name = "dgvQuests";
            dgvQuests.ReadOnly = true;
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.Size = new Size(312, 204);
            dgvQuests.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(399, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(45, 45);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(330, 433);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(43, 43);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // rdbtnOn
            // 
            rdbtnOn.AutoSize = true;
            rdbtnOn.Location = new Point(330, 523);
            rdbtnOn.Name = "rdbtnOn";
            rdbtnOn.Size = new Size(41, 19);
            rdbtnOn.TabIndex = 23;
            rdbtnOn.Text = "On";
            rdbtnOn.UseVisualStyleBackColor = true;
            // 
            // rdbtnOff
            // 
            rdbtnOff.AutoSize = true;
            rdbtnOff.Location = new Point(330, 548);
            rdbtnOff.Name = "rdbtnOff";
            rdbtnOff.Size = new Size(42, 19);
            rdbtnOff.TabIndex = 24;
            rdbtnOff.Text = "Off";
            rdbtnOff.UseVisualStyleBackColor = true;
            rdbtnOff.CheckedChanged += rdbtnOff_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 501);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 25;
            label6.Text = "Autosave";
            // 
            // SuperAdventure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 666);
            Controls.Add(label6);
            Controls.Add(rdbtnOff);
            Controls.Add(rdbtnOn);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(dgvQuests);
            Controls.Add(dgvInventory);
            Controls.Add(rtbMessages);
            Controls.Add(rtbLocation);
            Controls.Add(btnNorth);
            Controls.Add(btnSouth);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            Controls.Add(btnUsePotion);
            Controls.Add(btnUseWeapon);
            Controls.Add(potionBox);
            Controls.Add(weaponBox);
            Controls.Add(label5);
            Controls.Add(lblLvl);
            Controls.Add(lblExP);
            Controls.Add(lblGold);
            Controls.Add(lblHP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuperAdventure";
            Text = "SuperAdventure";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHP;
        private Label lblGold;
        private Label lblExP;
        private Label lblLvl;
        private Label label5;
        private ComboBox weaponBox;
        private ComboBox potionBox;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnWest;
        private Button btnEast;
        private Button btnSouth;
        private Button btnNorth;
        private RichTextBox rtbLocation;
        private RichTextBox rtbMessages;
        private DataGridView dgvInventory;
        private DataGridView dgvQuests;
        private Button btnSave;
        private Button btnReset;
        private RadioButton rdbtnOn;
        private RadioButton rdbtnOff;
        private Label label6;
    }
}
