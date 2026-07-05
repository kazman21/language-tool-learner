using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Language_Learning_Tool.Data;
using Language_Learning_Tool.Models;

namespace Language_Learning_Tool
{
    // Munaf Kazi - Take Quiz
    // Presents a multiple-choice quiz using vocabulary filtered by category
    public partial class QuizForm : Form
    {
        private List<VocabularyEntry> _questions;
        private List<VocabularyEntry> _allVocab;
        private List<string> _currentOptions;
        private int _currentQuestionIndex;
        private int _score;
        private List<VocabularyEntry> _incorrectWords;
        private Random _random;

        public QuizForm()
        {
            InitializeComponent();
            _random = new Random();
            _incorrectWords = new List<VocabularyEntry>();
            LoadCategories();
            SetQuizControlsVisible(false);
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

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            _allVocab = CsvDataService.LoadVocabulary();
            string category = cmbCategory.SelectedItem?.ToString();

            List<VocabularyEntry> pool;
            if (category != null && category != "All Categories")
                pool = _allVocab.Where(v => v.Category == category).ToList();
            else
                pool = _allVocab.ToList();

            if (pool.Count < 4)
            {
                MessageBox.Show("Need at least 4 words in the selected category to run a quiz.",
                    "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Shuffle and take up to 10 questions
            _questions = pool.OrderBy(_ => _random.Next()).Take(10).ToList();
            _currentQuestionIndex = 0;
            _score = 0;
            _incorrectWords.Clear();

            btnStartQuiz.Enabled = false;
            cmbCategory.Enabled = false;
            SetQuizControlsVisible(true);
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            var question = _questions[_currentQuestionIndex];
            _currentOptions = GenerateOptions(question);

            lblQuestionNumber.Text = $"Question {_currentQuestionIndex + 1} of {_questions.Count}";
            lblQuestion.Text = $"What is the meaning of \"{question.Word}\"?";

            radA.Text = $"A)  {_currentOptions[0]}";
            radB.Text = $"B)  {_currentOptions[1]}";
            radC.Text = $"C)  {_currentOptions[2]}";
            radD.Text = $"D)  {_currentOptions[3]}";

            // Clear selection
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;

            SetOptionsEnabled(true);
            lblFeedback.Text = "";
            lblFeedback.ForeColor = Color.Black;
            btnSubmit.Visible = true;
            btnNext.Visible = false;
        }

        // Munaf Kazi - Take Quiz
        // Builds 4 answer choices: 1 correct + 3 random wrong meanings from other entries
        private List<string> GenerateOptions(VocabularyEntry question)
        {
            var wrongOptions = _allVocab
                .Where(v => v.Id != question.Id)
                .OrderBy(_ => _random.Next())
                .Take(3)
                .Select(v => v.Meaning)
                .ToList();

            var options = new List<string> { question.Meaning };
            options.AddRange(wrongOptions);

            // Shuffle the 4 options so the correct answer isn't always first
            for (int i = options.Count - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                var temp = options[i];
                options[i] = options[j];
                options[j] = temp;
            }
            return options;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selected = null;
            if (radA.Checked) selected = _currentOptions[0];
            else if (radB.Checked) selected = _currentOptions[1];
            else if (radC.Checked) selected = _currentOptions[2];
            else if (radD.Checked) selected = _currentOptions[3];

            if (selected == null)
            {
                MessageBox.Show("Please select an answer.", "No Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var question = _questions[_currentQuestionIndex];
            bool isCorrect = selected == question.Meaning;

            if (isCorrect)
            {
                _score++;
                lblFeedback.Text = "Correct!";
                lblFeedback.ForeColor = Color.Green;
            }
            else
            {
                _incorrectWords.Add(question);
                lblFeedback.Text = $"Incorrect. The correct answer was: \"{question.Meaning}\"";
                lblFeedback.ForeColor = Color.Red;
            }

            SetOptionsEnabled(false);
            btnSubmit.Visible = false;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex < _questions.Count - 1)
            {
                _currentQuestionIndex++;
                ShowQuestion();
            }
            else
            {
                EndQuiz();
            }
        }

        // Munaf Kazi - Take Quiz / Track Progress / Review Incorrect Answers
        // Saves quiz results to AppSession and displays the final score
        private void EndQuiz()
        {
            AppSession.Progress.QuizzesTaken++;
            AppSession.Progress.TotalCorrect += _score;
            AppSession.Progress.TotalQuestions += _questions.Count;

            foreach (var word in _incorrectWords)
            {
                if (!AppSession.Progress.IncorrectWords.Any(w => w.Id == word.Id))
                    AppSession.Progress.IncorrectWords.Add(word);
            }

            SetQuizControlsVisible(false);
            btnStartQuiz.Enabled = true;
            cmbCategory.Enabled = true;

            MessageBox.Show(
                $"Quiz complete!\nScore: {_score} / {_questions.Count}\n({(double)_score / _questions.Count * 100:F0}%)",
                "Quiz Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetOptionsEnabled(bool enabled)
        {
            radA.Enabled = enabled;
            radB.Enabled = enabled;
            radC.Enabled = enabled;
            radD.Enabled = enabled;
        }

        private void SetQuizControlsVisible(bool visible)
        {
            lblQuestionNumber.Visible = visible;
            lblQuestion.Visible = visible;
            radA.Visible = visible;
            radB.Visible = visible;
            radC.Visible = visible;
            radD.Visible = visible;
            btnSubmit.Visible = visible;
            btnNext.Visible = false;
            lblFeedback.Visible = visible;
        }

        private void lblQuestionNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
