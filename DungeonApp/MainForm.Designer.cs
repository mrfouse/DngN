namespace DungeonApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstDungeons = new System.Windows.Forms.ListBox();
            this.btnAddDungeon = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumberOfPrisoners = new System.Windows.Forms.Label();
            this.txtNumberOfPrisoners = new System.Windows.Forms.TextBox();
            this.lblNumberOfMonsters = new System.Windows.Forms.Label();
            this.txtNumberOfMonsters = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDungeons
            // 
            this.lstDungeons.FormattingEnabled = true;
            this.lstDungeons.ItemHeight = 16;
            this.lstDungeons.Location = new System.Drawing.Point(12, 12);
            this.lstDungeons.Name = "lstDungeons";
            this.lstDungeons.Size = new System.Drawing.Size(360, 180);
            this.lstDungeons.TabIndex = 0;
            // 
            // btnAddDungeon
            // 
            this.btnAddDungeon.Location = new System.Drawing.Point(12, 200);
            this.btnAddDungeon.Name = "btnAddDungeon";
            this.btnAddDungeon.Size = new System.Drawing.Size(150, 30);
            this.btnAddDungeon.TabIndex = 1;
            this.btnAddDungeon.Text = "Добавить темницу";
            this.btnAddDungeon.UseVisualStyleBackColor = true;
            this.btnAddDungeon.Click += new System.EventHandler(this.btnAddDungeon_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumberOfPrisoners
            // 
            this.lblNumberOfPrisoners.AutoSize = true;
            this.lblNumberOfPrisoners.Location = new System.Drawing.Point(12, 250);
            this.lblNumberOfPrisoners.Name = "lblNumberOfPrisoners";
            this.lblNumberOfPrisoners.Size = new System.Drawing.Size(93, 17);
            this.lblNumberOfPrisoners.TabIndex = 3;
            this.lblNumberOfPrisoners.Text = "Число узников";
            // 
            // txtNumberOfPrisoners
            // 
            this.txtNumberOfPrisoners.Location = new System.Drawing.Point(130, 250);
            this.txtNumberOfPrisoners.Name = "txtNumberOfPrisoners";
            this.txtNumberOfPrisoners.Size = new System.Drawing.Size(150, 22);
            this.txtNumberOfPrisoners.TabIndex = 4;
            // 
            // lblNumberOfMonsters
            // 
            this.lblNumberOfMonsters.AutoSize = true;
            this.lblNumberOfMonsters.Location = new System.Drawing.Point(12, 290);
            this.lblNumberOfMonsters.Name = "lblNumberOfMonsters";
            this.lblNumberOfMonsters.Size = new System.Drawing.Size(100, 17);
            this.lblNumberOfMonsters.TabIndex = 5;
            this.lblNumberOfMonsters.Text = "Число монстров";
            // 
            // txtNumberOfMonsters
            // 
            this.txtNumberOfMonsters.Location = new System.Drawing.Point(130, 290);
            this.txtNumberOfMonsters.Name = "txtNumberOfMonsters";
            this.txtNumberOfMonsters.Size = new System.Drawing.Size(150, 22);
            this.txtNumberOfMonsters.TabIndex = 6;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(12, 330);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(94, 17);
            this.lblMode.TabIndex = 7;
            this.lblMode.Text = "Режим темницы";
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Тяжелый"});
            this.cboMode.Location = new System.Drawing.Point(130, 330);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(150, 24);
            this.cboMode.TabIndex = 8;
            // 
            // btnDistribute
            // 
            this.btnDistribute.Location = new System.Drawing.Point(12, 370);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(360, 30);
            this.btnDistribute.TabIndex = 9;
            this.btnDistribute.Text = "Расселить";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.txtNumberOfMonsters);
            this.Controls.Add(this.lblNumberOfMonsters);
            this.Controls.Add(this.txtNumberOfPrisoners);
            this.Controls.Add(this.lblNumberOfPrisoners);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddDungeon);
            this.Controls.Add(this.lstDungeons);
            this.Name = "MainForm";
            this.Text = "Управление темницами";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstDungeons;
        private System.Windows.Forms.Button btnAddDungeon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumberOfPrisoners;
        private System.Windows.Forms.TextBox txtNumberOfPrisoners;
        private System.Windows.Forms.Label lblNumberOfMonsters;
        private System.Windows.Forms.TextBox txtNumberOfMonsters;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Button btnDistribute;
    }
}
