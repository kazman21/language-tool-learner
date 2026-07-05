using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Language_Learning_Tool.Data;
using Language_Learning_Tool.Models;

namespace Language_Learning_Tool
{
    // Munaf Kazi - Practice Flashcards
    // Lets the learner flip through shuffled vocabulary cards filtered by category
    public partial class FlashcardForm : Form
    {
        private List<VocabularyEntry> _cards;
        private int _currentIndex;
        private bool _isFlipped;
        private bool _sessionActive;
        private HashSet<int> _seenIds;
        private Random _random;

        public FlashcardForm()
        {
            InitializeComponent();
            _cards = new List<VocabularyEntry>();
            _seenIds = new HashSet<int>();
            _random = new Random();
            LoadCategories();
            SetControlsEnabled(false);
        }

        private void LoadCategories()
        {
            var vocab = CsvDataService.LoadVocabulary();
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            foreach (var cat in vocab.Select(v => v.Category).Distinct().OrderBy(c => c))
                cmbCategory.Items.Add(cat);
            cmbCategory.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var allVocab = CsvDataService.LoadVocabulary();
            string category = cmbCategory.SelectedItem?.ToString();

            if (category != null && category != "All Categories")
                _cards = allVocab.Where(v => v.Category == category).ToList();
            else
                _cards = allVocab.ToList();

            if (_cards.Count == 0)
            {
                MessageBox.Show("No words found for the selected category.", "No Words", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            for (int i = _cards.Count - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                var temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }

            _currentIndex = 0;
            _isFlipped = false;
            _seenIds.Clear();
            _sessionActive = true;
            SetControlsEnabled(true);
            btnStart.Enabled = false;
            cmbCategory.Enabled = false;
            ShowCard();
        }

        // Displays the front of the current card (word only)
        private void ShowCard()
        {
            var card = _cards[_currentIndex];
            _seenIds.Add(card.Id);
            _isFlipped = false;

            lblProgress.Text = $"Card {_currentIndex + 1} of {_cards.Count}";
            lblCardFront.Text = card.Word;
            lblCardFront.Visible = true;
            lblCardBack.Visible = false;
            pnlCard.BackColor = SystemColors.Window;
        }

        // Munaf Kazi - Practice Flashcards
        // Toggles between word (front) and meaning + example (back)
        private void FlipCard()
        {
            if (!_sessionActive) return;
            var card = _cards[_currentIndex];
            _isFlipped = !_isFlipped;

            if (_isFlipped)
            {
                lblCardFront.Visible = false;
                lblCardBack.Text = $"Meaning:\n{card.Meaning}\n\nExample:\n{card.ExampleSentence}";
                lblCardBack.Visible = true;
                pnlCard.BackColor = Color.LightYellow;
            }
            else
            {
                lblCardFront.Visible = true;
                lblCardBack.Visible = false;
                pnlCard.BackColor = SystemColors.Window;
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            FlipCard();
        }

        private void pnlCard_Click(object sender, EventArgs e)
        {
            FlipCard();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _cards.Count - 1)
            {
                _currentIndex++;
                ShowCard();
            }
            else
            {
                EndSession();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                ShowCard();
            }
        }

        // Records the session's practiced word count in AppSession then resets the form
        private void EndSession()
        {
            AppSession.Progress.FlashcardWordsPracticed += _seenIds.Count;
            _sessionActive = false;

            MessageBox.Show(
                $"Session complete! You practiced {_seenIds.Count} word(s).",
                "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetControlsEnabled(false);
            btnStart.Enabled = true;
            cmbCategory.Enabled = true;
            lblProgress.Text = "Select a category and press Start";
            lblCardFront.Text = "";
            lblCardBack.Text = "";
            pnlCard.BackColor = SystemColors.Control;
        }

        private void SetControlsEnabled(bool enabled)
        {
            btnFlip.Enabled = enabled;
            btnNext.Enabled = enabled;
            btnPrevious.Enabled = enabled;
        }
    }
}
