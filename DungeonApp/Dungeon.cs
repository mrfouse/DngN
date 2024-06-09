using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DungeonApp
{
    public class Dungeon
    {
        public string Name { get; set; }
        public int NumberOfCells { get; set; }
        public int NumberOfPrisoners { get; set; }
        public int NumberOfMonsters { get; set; }
        public double CellSize { get; set; }
        public List<string> WorkingHours { get; set; }
        public string Mode { get; set; }

        public Dungeon(string name, int numberOfCells, int numberOfPrisoners, int numberOfMonsters, double cellSize, List<string> workingHours, string mode)
        {
            Name = name;
            NumberOfCells = numberOfCells;
            NumberOfPrisoners = numberOfPrisoners;
            NumberOfMonsters = numberOfMonsters;
            CellSize = cellSize;
            WorkingHours = workingHours;
            Mode = mode;
        }

        public TimeSpan CalculateWorkingDayDuration()
        {
            TimeSpan totalDuration = new TimeSpan();
            foreach (var range in WorkingHours)
            {
                var times = range.Split('-');
                if (times.Length == 2)
                {
                    TimeSpan startTime = TimeSpan.Parse(times[0].Trim());
                    TimeSpan endTime = TimeSpan.Parse(times[1].Trim());
                    if (endTime > startTime)
                    {
                        totalDuration += (endTime - startTime);
                    }
                }
            }
            return totalDuration;
        }

        public void AddPrisoners(int newPrisoners)
        {
            NumberOfPrisoners += newPrisoners;
        }

        public void AddMonsters(int newMonsters)
        {
            NumberOfMonsters += newMonsters;
        }

        public static bool ValidateWorkingHours(string input)
        {
            string pattern = @"^\d{2}[:\-]\d{2}\s*-\s*\d{2}[:\-]\d{2}(\s*[, ]\s*\d{2}[:\-]\d{2}\s*-\s*\d{2}[:\-]\d{2})*$";
            return Regex.IsMatch(input, pattern);
        }


        public static bool ValidateCellSize(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
