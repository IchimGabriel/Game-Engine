namespace Game
{
    partial class StartGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.BtnUseWeapon = new System.Windows.Forms.Button();
            this.BtnUsePotion = new System.Windows.Forms.Button();
            this.BtnNorth = new System.Windows.Forms.Button();
            this.BtnEast = new System.Windows.Forms.Button();
            this.BtnSouth = new System.Windows.Forms.Button();
            this.BtnWest = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(214, 18);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(51, 20);
            this.lblHitPoints.TabIndex = 6;
            this.lblHitPoints.Text = "label5";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(214, 44);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(51, 20);
            this.lblGold.TabIndex = 7;
            this.lblGold.Text = "label5";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(214, 72);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(51, 20);
            this.lblExperience.TabIndex = 8;
            this.lblExperience.Text = "label5";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(214, 98);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(51, 20);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 753);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(585, 803);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 28);
            this.cboWeapons.TabIndex = 11;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(585, 837);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 28);
            this.cboPotions.TabIndex = 12;
            // 
            // BtnUseWeapon
            // 
            this.BtnUseWeapon.Location = new System.Drawing.Point(787, 790);
            this.BtnUseWeapon.Name = "BtnUseWeapon";
            this.BtnUseWeapon.Size = new System.Drawing.Size(131, 41);
            this.BtnUseWeapon.TabIndex = 13;
            this.BtnUseWeapon.Text = "Use Weapon";
            this.BtnUseWeapon.UseVisualStyleBackColor = true;
            this.BtnUseWeapon.Click += new System.EventHandler(this.BtnUseWeapon_Click_1);
            // 
            // BtnUsePotion
            // 
            this.BtnUsePotion.Location = new System.Drawing.Point(788, 831);
            this.BtnUsePotion.Name = "BtnUsePotion";
            this.BtnUsePotion.Size = new System.Drawing.Size(131, 41);
            this.BtnUsePotion.TabIndex = 14;
            this.BtnUsePotion.Text = "Use Potion";
            this.BtnUsePotion.UseVisualStyleBackColor = true;
            // 
            // BtnNorth
            // 
            this.BtnNorth.Location = new System.Drawing.Point(709, 579);
            this.BtnNorth.Name = "BtnNorth";
            this.BtnNorth.Size = new System.Drawing.Size(131, 42);
            this.BtnNorth.TabIndex = 15;
            this.BtnNorth.Text = "North";
            this.BtnNorth.UseVisualStyleBackColor = true;
            this.BtnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // BtnEast
            // 
            this.BtnEast.Location = new System.Drawing.Point(789, 623);
            this.BtnEast.Name = "BtnEast";
            this.BtnEast.Size = new System.Drawing.Size(131, 42);
            this.BtnEast.TabIndex = 16;
            this.BtnEast.Text = "East";
            this.BtnEast.UseVisualStyleBackColor = true;
            this.BtnEast.Click += new System.EventHandler(this.BtnEast_Click);
            // 
            // BtnSouth
            // 
            this.BtnSouth.Location = new System.Drawing.Point(709, 667);
            this.BtnSouth.Name = "BtnSouth";
            this.BtnSouth.Size = new System.Drawing.Size(131, 42);
            this.BtnSouth.TabIndex = 17;
            this.BtnSouth.Text = "South";
            this.BtnSouth.UseVisualStyleBackColor = true;
            this.BtnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
            // 
            // BtnWest
            // 
            this.BtnWest.Location = new System.Drawing.Point(628, 623);
            this.BtnWest.Name = "BtnWest";
            this.BtnWest.Size = new System.Drawing.Size(131, 42);
            this.BtnWest.TabIndex = 18;
            this.BtnWest.Text = "West";
            this.BtnWest.UseVisualStyleBackColor = true;
            this.BtnWest.Click += new System.EventHandler(this.BtnWest_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(537, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(421, 105);
            this.rtbLocation.TabIndex = 19;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(537, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(421, 425);
            this.rtbMessages.TabIndex = 20;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.Size = new System.Drawing.Size(432, 309);
            this.dgvInventory.TabIndex = 21;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowTemplate.Height = 28;
            this.dgvQuests.Size = new System.Drawing.Size(432, 189);
            this.dgvQuests.TabIndex = 22;
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 958);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.BtnWest);
            this.Controls.Add(this.BtnSouth);
            this.Controls.Add(this.BtnEast);
            this.Controls.Add(this.BtnNorth);
            this.Controls.Add(this.BtnUsePotion);
            this.Controls.Add(this.BtnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartGame";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.StartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button BtnUseWeapon;
        private System.Windows.Forms.Button BtnUsePotion;
        private System.Windows.Forms.Button BtnNorth;
        private System.Windows.Forms.Button BtnEast;
        private System.Windows.Forms.Button BtnSouth;
        private System.Windows.Forms.Button BtnWest;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

