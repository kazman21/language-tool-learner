using System;
using System.Windows.Forms;
using Language_Learning_Tool.Data;

namespace Language_Learning_Tool
{
    // Alexander Borrmann - Set Daily Learning Goal
    // Allows the learner to set a target number of words to practice per session
    public partial class GoalForm : Form
    {
        public GoalForm()
        {
            InitializeComponent();
            var goal = CsvDataService.LoadGoal();
            numTarget.Value = goal.TargetWordCount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var goal = new Models.DailyGoal { TargetWordCount = (int)numTarget.Value };
            CsvDataService.SaveGoal(goal);
            AppSession.Goal = goal;
            MessageBox.Show("Goal saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
