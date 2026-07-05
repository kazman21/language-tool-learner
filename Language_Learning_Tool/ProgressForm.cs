using System;
using System.Windows.Forms;

namespace Language_Learning_Tool
{
    // Munaf Kazi - Track Progress
    // Displays current session statistics and daily goal progress
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            LoadStats();
        }

        private void LoadStats()
        {
            var progress = AppSession.Progress;
            var goal = AppSession.Goal;

            lblQuizzesTaken.Text = $"Quizzes Taken:             {progress.QuizzesTaken}";
            lblTotalQuestions.Text = $"Total Questions Answered:  {progress.TotalQuestions}";
            lblCorrect.Text = $"Correct Answers:           {progress.TotalCorrect}";
            lblAvgScore.Text = $"Average Score:             {progress.AverageScore:F1}%";
            lblFlashcards.Text = $"Flashcard Words Practiced: {progress.FlashcardWordsPracticed}";

            int totalPracticed = progress.FlashcardWordsPracticed + progress.TotalQuestions;
            int target = goal.TargetWordCount;
            string goalStatus = totalPracticed >= target ? "  (Goal reached!)" : "";
            lblGoalProgress.Text = $"Daily Goal:                {target} words";
            lblPracticed.Text = $"Practiced This Session:    {totalPracticed} / {target}{goalStatus}";

            btnReview.Enabled = progress.IncorrectWords.Count > 0;
        }

        // Munaf Kazi - Review Incorrect Answers
        // Opens the review form showing words answered wrong in this session
        private void btnReview_Click(object sender, EventArgs e)
        {
            using (var form = new ReviewForm())
                form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAvgScore_Click(object sender, EventArgs e)
        {

        }
    }
}
