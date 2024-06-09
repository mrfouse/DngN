using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DungeonApp
{
    public partial class AddDungeonForm : Form
    {
        public Dungeon NewDungeon { get; private set; }

        public AddDungeonForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate and save the dungeon data
            string name = txtName.Text;
            if (!int.TryParse(txtNumberOfCells.Text, out int numberOfCells) || numberOfCells <= 0)
            {
                MessageBox.Show("Неверное число камер");
                return;
            }
            if (!double.TryParse(txtCellSize.Text, out double cellSize) || cellSize <= 0)
            {
                MessageBox.Show("Неверный размер камеры");
                return;
            }
            string workingHoursInput = txtWorkingHours.Text;
            if (!Dungeon.ValidateWorkingHours(workingHoursInput))
            {
                MessageBox.Show("Неверный формат рабочих часов");
                return;
            }
            List<string> workingHours = new List<string>(workingHoursInput.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string mode = cboMode.SelectedItem.ToString();

            NewDungeon = new Dungeon(name, numberOfCells, 0, 0, cellSize, workingHours, mode);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
