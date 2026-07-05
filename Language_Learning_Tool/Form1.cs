using System;
using System.Windows.Forms;
using Language_Learning_Tool.Data;

namespace Language_Learning_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshGoalDisplay();
        }

        // Alexander Borrmann - Set Daily Learning Goal
        // Reloads the goal from disk and recalculates session progress for the dashboard label
        private void RefreshGoalDisplay()
        {
            AppSession.Goal = CsvDataService.LoadGoal();
            int target = AppSession.Goal.TargetWordCount;
            int practiced = AppSession.Progress.FlashcardWordsPracticed + AppSession.Progress.TotalQuestions;
            lblGoalStatus.Text = $"Daily Goal: {target} words  —  Practiced this session: {practiced} / {target}";
        }

        // Munaf Kazi - Add New Vocabulary
        // Opens the vocabulary management form
        private void btnVocabulary_Click(object sender, EventArgs e)
        {
            using (var form = new VocabularyForm())
                form.ShowDialog();
        }

        // Munaf Kazi - Practice Flashcards
        // Opens the flashcard practice form; requires at least one saved word
        private void btnFlashcards_Click(object sender, EventArgs e)
        {
            if (CsvDataService.LoadVocabulary().Count == 0)
            {
                MessageBox.Show("No vocabulary entries found. Please add some words first.",
                    "No Vocabulary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new FlashcardForm())
                form.ShowDialog();
            RefreshGoalDisplay();
        }

        // Munaf Kazi - Take Quiz
        // Opens the quiz form; requires at least 4 words to generate multiple-choice options
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            if (CsvDataService.LoadVocabulary().Count < 4)
            {
                MessageBox.Show("You need at least 4 vocabulary entries to take a quiz.",
                    "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var form = new QuizForm())
                form.ShowDialog();
            RefreshGoalDisplay();
        }

        // Munaf Kazi - Track Progress
        // Opens the session progress and stats form
        private void btnProgress_Click(object sender, EventArgs e)
        {
            using (var form = new ProgressForm())
                form.ShowDialog();
        }

        // Alexander Borrmann - Categorize Vocabulary
        // Opens the category management form
        private void btnCategories_Click(object sender, EventArgs e)
        {
            using (var form = new CategoryForm())
                form.ShowDialog();
        }

        // Alexander Borrmann - Set Daily Learning Goal
        // Opens the goal-setting form and refreshes the dashboard label on return
        private void btnGoal_Click(object sender, EventArgs e)
        {
            using (var form = new GoalForm())
                form.ShowDialog();
            RefreshGoalDisplay();
        }

        private void lblGoalStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
