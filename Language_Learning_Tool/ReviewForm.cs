using System;
using System.Windows.Forms;

namespace Language_Learning_Tool
{
    // Munaf Kazi - Review Incorrect Answers
    // Shows all words the learner answered incorrectly during this session's quizzes
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            LoadIncorrectWords();
        }

        private void LoadIncorrectWords()
        {
            dgvIncorrect.Rows.Clear();
            foreach (var entry in AppSession.Progress.IncorrectWords)
            {
                dgvIncorrect.Rows.Add(entry.Word, entry.Meaning, entry.ExampleSentence);
            }

            if (AppSession.Progress.IncorrectWords.Count == 0)
            {
                lblNote.Text = "No incorrect answers recorded this session.";
            }
            else
            {
                lblNote.Text = $"{AppSession.Progress.IncorrectWords.Count} word(s) answered incorrectly this session:";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
