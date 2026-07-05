namespace Language_Learning_Tool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGoalStatus = new System.Windows.Forms.Label();
            this.btnVocabulary = new System.Windows.Forms.Button();
            this.btnFlashcards = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Language Learning Tool";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoalStatus
            // 
            this.lblGoalStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGoalStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblGoalStatus.Location = new System.Drawing.Point(60, 120);
            this.lblGoalStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalStatus.Name = "lblGoalStatus";
            this.lblGoalStatus.Size = new System.Drawing.Size(630, 34);
            this.lblGoalStatus.TabIndex = 1;
            this.lblGoalStatus.Text = "Daily Goal: 10 words  -  Practiced this session: 0 / 10";
            this.lblGoalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoalStatus.Click += new System.EventHandler(this.lblGoalStatus_Click);
            // 
            // btnVocabulary
            // 
            this.btnVocabulary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVocabulary.Location = new System.Drawing.Point(120, 192);
            this.btnVocabulary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVocabulary.Name = "btnVocabulary";
            this.btnVocabulary.Size = new System.Drawing.Size(255, 74);
            this.btnVocabulary.TabIndex = 2;
            this.btnVocabulary.Text = "Manage Vocabulary";
            this.btnVocabulary.Click += new System.EventHandler(this.btnVocabulary_Click);
            // 
            // btnFlashcards
            // 
            this.btnFlashcards.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnFlashcards.Location = new System.Drawing.Point(405, 192);
            this.btnFlashcards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFlashcards.Name = "btnFlashcards";
            this.btnFlashcards.Size = new System.Drawing.Size(255, 74);
            this.btnFlashcards.TabIndex = 3;
            this.btnFlashcards.Text = "Practice Flashcards";
            this.btnFlashcards.Click += new System.EventHandler(this.btnFlashcards_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnQuiz.Location = new System.Drawing.Point(120, 297);
            this.btnQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(255, 74);
            this.btnQuiz.TabIndex = 4;
            this.btnQuiz.Text = "Take a Quiz";
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnProgress.Location = new System.Drawing.Point(405, 297);
            this.btnProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(255, 74);
            this.btnProgress.TabIndex = 5;
            this.btnProgress.Text = "View Progress";
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCategories.Location = new System.Drawing.Point(120, 402);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(255, 74);
            this.btnCategories.TabIndex = 6;
            this.btnCategories.Text = "Manage Categories";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnGoal
            // 
            this.btnGoal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnGoal.Location = new System.Drawing.Point(405, 402);
            this.btnGoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(255, 74);
            this.btnGoal.TabIndex = 7;
            this.btnGoal.Text = "Set Daily Goal";
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 523);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGoalStatus);
            this.Controls.Add(this.btnVocabulary);
            this.Controls.Add(this.btnFlashcards);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnGoal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Learning Tool";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGoalStatus;
        private System.Windows.Forms.Button btnVocabulary;
        private System.Windows.Forms.Button btnFlashcards;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnGoal;
    }
}
