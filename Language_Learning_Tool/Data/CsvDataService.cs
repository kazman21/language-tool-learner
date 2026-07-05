using System.Collections.Generic;
using System.IO;
using System.Text;
using Language_Learning_Tool.Models;

namespace Language_Learning_Tool.Data
{
    // Handles all CSV read/write operations for vocabulary and daily goal
    public static class CsvDataService
    {
        private static readonly string VocabFilePath = "vocabulary.csv";
        private static readonly string GoalFilePath = "goal.csv";

        // Munaf Kazi - Add New Vocabulary / Alexander Borrmann - Edit, Delete, Search Vocabulary
        // Reads all vocabulary entries from the CSV file
        public static List<VocabularyEntry> LoadVocabulary()
        {
            var entries = new List<VocabularyEntry>();
            if (!File.Exists(VocabFilePath))
                return entries;

            foreach (var line in File.ReadAllLines(VocabFilePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = ParseCsvLine(line);
                if (parts.Length < 5) continue;
                entries.Add(new VocabularyEntry
                {
                    Id = int.TryParse(parts[0], out int id) ? id : 0,
                    Word = parts[1],
                    Meaning = parts[2],
                    ExampleSentence = parts[3],
                    Category = parts[4]
                });
            }
            return entries;
        }

        // Writes the full vocabulary list to the CSV file, overwriting existing data
        public static void SaveVocabulary(List<VocabularyEntry> entries)
        {
            var lines = new List<string>();
            foreach (var entry in entries)
            {
                lines.Add(string.Join(",", new[]
                {
                    entry.Id.ToString(),
                    EscapeCsv(entry.Word),
                    EscapeCsv(entry.Meaning),
                    EscapeCsv(entry.ExampleSentence),
                    EscapeCsv(entry.Category)
                }));
            }
            File.WriteAllLines(VocabFilePath, lines);
        }

        // Alexander Borrmann - Set Daily Learning Goal
        // Reads the saved goal from disk; returns a default if not found
        public static DailyGoal LoadGoal()
        {
            if (!File.Exists(GoalFilePath))
                return new DailyGoal();
            var lines = File.ReadAllLines(GoalFilePath);
            if (lines.Length > 0 && int.TryParse(lines[0].Trim(), out int target))
                return new DailyGoal { TargetWordCount = target };
            return new DailyGoal();
        }

        // Saves the daily goal target to disk
        public static void SaveGoal(DailyGoal goal)
        {
            File.WriteAllText(GoalFilePath, goal.TargetWordCount.ToString());
        }

        private static string EscapeCsv(string value)
        {
            if (value == null) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        private static string[] ParseCsvLine(string line)
        {
            var fields = new List<string>();
            bool inQuotes = false;
            var current = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (inQuotes)
                {
                    if (c == '"' && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else if (c == '"')
                    {
                        inQuotes = false;
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
                else
                {
                    if (c == '"')
                        inQuotes = true;
                    else if (c == ',')
                    {
                        fields.Add(current.ToString());
                        current.Clear();
                    }
                    else
                        current.Append(c);
                }
            }
            fields.Add(current.ToString());
            return fields.ToArray();
        }
    }
}
