using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DungeonApp
{
    public partial class MainForm : Form
    {
        private List<Dungeon> dungeonList = new List<Dungeon>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddDungeon_Click(object sender, EventArgs e)
        {
            using (var form = new AddDungeonForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newDungeon = form.NewDungeon;
                    dungeonList.Add(newDungeon);
                    UpdateDungeonList();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dungeonList.Clear();
            UpdateDungeonList();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            int numberOfPrisoners;
            if (!int.TryParse(txtNumberOfPrisoners.Text, out numberOfPrisoners) || numberOfPrisoners <= 0)
            {
                MessageBox.Show("Неверное число узников");
                return;
            }

            int numberOfMonsters;
            if (!int.TryParse(txtNumberOfMonsters.Text, out numberOfMonsters) || numberOfMonsters < 0)
            {
                MessageBox.Show("Неверное число монстров");
                return;
            }

            if (cboMode.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите режим темницы");
                return;
            }

            string mode = cboMode.SelectedItem.ToString();
            DistributeEntities(numberOfPrisoners, numberOfMonsters, mode);
        }

        private void DistributeEntities(int numberOfPrisoners, int numberOfMonsters, string mode)
        {
            DistributePrisoners(numberOfPrisoners, mode);
            DistributeMonsters(numberOfMonsters, mode);
            UpdateDungeonList();
        }

        private void DistributePrisoners(int numberOfPrisoners, string mode)
        {
            var filteredDungeons = dungeonList.Where(d => d.Mode == mode).OrderBy(d => d.NumberOfPrisoners).ToList();

            int remainingPrisoners = numberOfPrisoners;
            int index = 0;

            while (remainingPrisoners > 0 && index < filteredDungeons.Count)
            {
                var dungeon = filteredDungeons[index];
                int spaceAvailable = dungeon.NumberOfCells * (int)dungeon.CellSize - dungeon.NumberOfPrisoners;
                int prisonersToAdd = Math.Min(remainingPrisoners, spaceAvailable);

                dungeon.AddPrisoners(prisonersToAdd);
                remainingPrisoners -= prisonersToAdd;
                index++;
            }

            if (remainingPrisoners > 0)
            {
                MessageBox.Show("Недостаточно места в темницах для размещения всех узников");
            }
        }

        private void DistributeMonsters(int numberOfMonsters, string mode)
        {
            var filteredDungeons = dungeonList.Where(d => d.Mode == mode).OrderBy(d => d.NumberOfMonsters).ToList();

            int remainingMonsters = numberOfMonsters;
            int index = 0;

            while (remainingMonsters > 0 && index < filteredDungeons.Count)
            {
                var dungeon = filteredDungeons[index];
                int spaceAvailable = dungeon.NumberOfCells * (int)dungeon.CellSize - dungeon.NumberOfMonsters;
                int monstersToAdd = Math.Min(remainingMonsters, spaceAvailable);

                dungeon.AddMonsters(monstersToAdd);
                remainingMonsters -= monstersToAdd;
                index++;
            }

            if (remainingMonsters > 0)
            {
                MessageBox.Show("Недостаточно места в темницах для размещения всех монстров");
            }
        }

        private void UpdateDungeonList()
        {
            lstDungeons.Items.Clear();
            foreach (var dungeon in dungeonList)
            {
                lstDungeons.Items.Add($"{dungeon.Name} - Узники: {dungeon.NumberOfPrisoners}/{dungeon.NumberOfCells * (int)dungeon.CellSize}, Монстры: {dungeon.NumberOfMonsters}/{dungeon.NumberOfCells * (int)dungeon.CellSize}");
            }
        }
    }
}
