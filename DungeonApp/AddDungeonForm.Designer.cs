namespace DungeonApp
{
    partial class AddDungeonForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumberOfCells = new System.Windows.Forms.Label();
            this.txtNumberOfCells = new System.Windows.Forms.TextBox();
            this.lblCellSize = new System.Windows.Forms.Label();
            this.txtCellSize = new System.Windows.Forms.TextBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.lblWorkingHoursFormat = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название темницы";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblNumberOfCells
            // 
            this.lblNumberOfCells.AutoSize = true;
            this.lblNumberOfCells.Location = new System.Drawing.Point(12, 70);
            this.lblNumberOfCells.Name = "lblNumberOfCells";
            this.lblNumberOfCells.Size = new System.Drawing.Size(87, 17);
            this.lblNumberOfCells.TabIndex = 2;
            this.lblNumberOfCells.Text = "Число камер";
            // 
            // txtNumberOfCells
            // 
            this.txtNumberOfCells.Location = new System.Drawing.Point(130, 70);
            this.txtNumberOfCells.Name = "txtNumberOfCells";
            this.txtNumberOfCells.Size = new System.Drawing.Size(200, 22);
            this.txtNumberOfCells.TabIndex = 3;
            // 
            // lblCellSize
            // 
            this.lblCellSize.AutoSize = true;
            this.lblCellSize.Location = new System.Drawing.Point(12, 110);
            this.lblCellSize.Name = "lblCellSize";
            this.lblCellSize.Size = new System.Drawing.Size(93, 17);
            this.lblCellSize.TabIndex = 4;
            this.lblCellSize.Text = "Размер камеры";
            // 
            // txtCellSize
            // 
            this.txtCellSize.Location = new System.Drawing.Point(130, 110);
            this.txtCellSize.Name = "txtCellSize";
            this.txtCellSize.Size = new System.Drawing.Size(200, 22);
            this.txtCellSize.TabIndex = 5;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Location = new System.Drawing.Point(12, 150);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(94, 17);
            this.lblWorkingHours.TabIndex = 6;
            this.lblWorkingHours.Text = "Рабочие часы";
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Location = new System.Drawing.Point(130, 150);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(200, 22);
            this.txtWorkingHours.TabIndex = 7;
            // 
            // lblWorkingHoursFormat
            // 
            this.lblWorkingHoursFormat.AutoSize = true;
            this.lblWorkingHoursFormat.Location = new System.Drawing.Point(130, 175);
            this.lblWorkingHoursFormat.Name = "lblWorkingHoursFormat";
            this.lblWorkingHoursFormat.Size = new System.Drawing.Size(215, 34);
            this.lblWorkingHoursFormat.TabIndex = 8;
            this.lblWorkingHoursFormat.Text = "Формат: ЧЧ:ММ-ЧЧ:ММ, ЧЧ-ММ-ЧЧ-ММ,\r\nРазделение: пробел, запятая";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(12, 230);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(94, 17);
            this.lblMode.TabIndex = 9;
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
            this.cboMode.Location = new System.Drawing.Point(130, 230);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(200, 24);
            this.cboMode.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddDungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblWorkingHoursFormat);
            this.Controls.Add(this.txtWorkingHours);
            this.Controls.Add(this.lblWorkingHours);
            this.Controls.Add(this.txtCellSize);
            this.Controls.Add(this.lblCellSize);
            this.Controls.Add(this.txtNumberOfCells);
            this.Controls.Add(this.lblNumberOfCells);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddDungeonForm";
            this.Text = "Добавить темницу";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumberOfCells;
        private System.Windows.Forms.TextBox txtNumberOfCells;
        private System.Windows.Forms.Label lblCellSize;
        private System.Windows.Forms.TextBox txtCellSize;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.Label lblWorkingHoursFormat;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
