using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Language_Learning_Tool.Data;
using Language_Learning_Tool.Models;

namespace Language_Learning_Tool
{
    public partial class VocabularyForm : Form
    {
        private List<VocabularyEntry> _allEntries;
        private bool _isEditing;
        private int _editingId;

        public VocabularyForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _allEntries = CsvDataService.LoadVocabulary();
            PopulateCategoryFilter();
            ApplyFilter();
        }

        // Alexander Borrmann - Search Vocabulary
        // Populates the category filter dropdown with distinct category values
        private void PopulateCategoryFilter()
        {
            string selected = cmbFilter.SelectedItem?.ToString();
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("All Categories");
            foreach (var cat in _allEntries.Select(e => e.Category).Distinct().OrderBy(c => c))
                cmbFilter.Items.Add(cat);
            cmbFilter.SelectedItem = selected ?? "All Categories";
            if (cmbFilter.SelectedIndex < 0) cmbFilter.SelectedIndex = 0;
        }

        // Alexander Borrmann - Search Vocabulary
        // Filters the grid by search text and selected category in real time
        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim().ToLower();
            string category = cmbFilter.SelectedItem?.ToString();

            var filtered = _allEntries.AsEnumerable();

            if (!string.IsNullOrEmpty(search))
                filtered = filtered.Where(e =>
                    e.Word.ToLower().Contains(search) ||
                    e.Meaning.ToLower().Contains(search));

            if (category != null && category != "All Categories")
                filtered = filtered.Where(e => e.Category == category);

            dgvVocabulary.Rows.Clear();
            foreach (var entry in filtered)
            {
                dgvVocabulary.Rows.Add(entry.Id, entry.Word, entry.Meaning, entry.ExampleSentence, entry.Category);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilter.SelectedIndex = 0;
        }

        // Munaf Kazi - Add New Vocabulary
        // Shows the add/edit panel in Add mode with empty fields
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _isEditing = false;
            _editingId = 0;
            ClearEditFields();
            lblPanelTitle.Text = "Add New Word";
            pnlEdit.Visible = true;
            txtWord.Focus();
        }

        // Alexander Borrmann - Edit Existing Vocabulary
        // Populates the edit panel with the selected row's data
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVocabulary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a word to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvVocabulary.SelectedRows[0].Cells["colId"].Value;
            var entry = _allEntries.FirstOrDefault(en => en.Id == id);
            if (entry == null) return;

            _isEditing = true;
            _editingId = id;
            txtWord.Text = entry.Word;
            txtMeaning.Text = entry.Meaning;
            txtExample.Text = entry.ExampleSentence;
            txtCategory.Text = entry.Category;
            lblPanelTitle.Text = "Edit Word";
            pnlEdit.Visible = true;
            txtWord.Focus();
        }

        // Alexander Borrmann - Delete Vocabulary
        // Asks for confirmation then permanently removes the selected word
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVocabulary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a word to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvVocabulary.SelectedRows[0].Cells["colId"].Value;
            var entry = _allEntries.FirstOrDefault(en => en.Id == id);
            if (entry == null) return;

            var result = MessageBox.Show(
                $"Are you sure you want to delete \"{entry.Word}\"?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            _allEntries.Remove(entry);
            CsvDataService.SaveVocabulary(_allEntries);
            PopulateCategoryFilter();
            ApplyFilter();
        }

        // Munaf Kazi - Add New Vocabulary / Alexander Borrmann - Edit Existing Vocabulary
        // Validates and saves the new or edited entry to the CSV
        private void btnSave_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            string meaning = txtMeaning.Text.Trim();
            string example = txtExample.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(meaning))
            {
                MessageBox.Show("Word and Meaning are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(category))
                category = "Uncategorized";

            if (_isEditing)
            {
                var entry = _allEntries.FirstOrDefault(en => en.Id == _editingId);
                if (entry != null)
                {
                    entry.Word = word;
                    entry.Meaning = meaning;
                    entry.ExampleSentence = example;
                    entry.Category = category;
                }
            }
            else
            {
                int newId = _allEntries.Count > 0 ? _allEntries.Max(en => en.Id) + 1 : 1;
                _allEntries.Add(new VocabularyEntry
                {
                    Id = newId,
                    Word = word,
                    Meaning = meaning,
                    ExampleSentence = example,
                    Category = category
                });
            }

            CsvDataService.SaveVocabulary(_allEntries);
            pnlEdit.Visible = false;
            PopulateCategoryFilter();
            ApplyFilter();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            ClearEditFields();
        }

        private void ClearEditFields()
        {
            txtWord.Clear();
            txtMeaning.Clear();
            txtExample.Clear();
            txtCategory.Clear();
        }
    }
}
