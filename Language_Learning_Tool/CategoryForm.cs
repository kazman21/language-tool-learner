using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Language_Learning_Tool.Data;
using Language_Learning_Tool.Models;

namespace Language_Learning_Tool
{
    // Alexander Borrmann - Categorize Vocabulary
    // Allows the learner to create categories and assign words to them
    public partial class CategoryForm : Form
    {
        private List<VocabularyEntry> _vocab;

        public CategoryForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _vocab = CsvDataService.LoadVocabulary();
            RefreshCategoryLists();
            RefreshWordList();
        }

        // Rebuilds the category dropdowns from the distinct categories in vocabulary
        private void RefreshCategoryLists()
        {
            var categories = _vocab
                .Select(v => v.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            // Also include any category typed into the new category box (not yet assigned)
            string pending = txtNewCategory.Text.Trim();
            if (!string.IsNullOrEmpty(pending) && !categories.Contains(pending))
                categories.Add(pending);

            cmbAssignTo.Items.Clear();
            cmbDeleteCategory.Items.Clear();

            foreach (var cat in categories)
            {
                cmbAssignTo.Items.Add(cat);
                cmbDeleteCategory.Items.Add(cat);
            }

            if (cmbAssignTo.Items.Count > 0) cmbAssignTo.SelectedIndex = 0;
            if (cmbDeleteCategory.Items.Count > 0) cmbDeleteCategory.SelectedIndex = 0;
        }

        // Populates the checked word list showing word and its current category
        private void RefreshWordList()
        {
            clbWords.Items.Clear();
            foreach (var entry in _vocab)
                clbWords.Items.Add($"{entry.Word}  [{entry.Category}]");
        }

        // Alexander Borrmann - Categorize Vocabulary
        // Adds the typed category name to the assign-to dropdown without saving to disk yet
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtNewCategory.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a category name.", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cmbAssignTo.Items.Contains(name))
                cmbAssignTo.Items.Add(name);
            if (!cmbDeleteCategory.Items.Contains(name))
                cmbDeleteCategory.Items.Add(name);

            cmbAssignTo.SelectedItem = name;
            txtNewCategory.Clear();
        }

        // Alexander Borrmann - Categorize Vocabulary
        // Assigns all checked words to the selected target category and saves to CSV
        private void btnAssign_Click(object sender, EventArgs e)
        {
            string targetCategory = cmbAssignTo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(targetCategory))
            {
                MessageBox.Show("Please select a target category.", "No Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbWords.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Please check at least one word to assign.", "No Words Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var checkedIndices = clbWords.CheckedIndices.Cast<int>().ToList();
            foreach (int i in checkedIndices)
                _vocab[i].Category = targetCategory;

            CsvDataService.SaveVocabulary(_vocab);
            RefreshCategoryLists();
            RefreshWordList();

            MessageBox.Show($"{checkedIndices.Count} word(s) assigned to \"{targetCategory}\".",
                "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Alexander Borrmann - Categorize Vocabulary
        // Deletes a category by reassigning all its words to Uncategorized
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string category = cmbDeleteCategory.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (category == "Uncategorized")
            {
                MessageBox.Show("The Uncategorized category cannot be deleted.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int wordCount = _vocab.Count(v => v.Category == category);
            var result = MessageBox.Show(
                $"Delete category \"{category}\"? {wordCount} word(s) will be moved to Uncategorized.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            foreach (var entry in _vocab.Where(v => v.Category == category))
                entry.Category = "Uncategorized";

            CsvDataService.SaveVocabulary(_vocab);
            RefreshCategoryLists();
            RefreshWordList();
        }
    }
}
