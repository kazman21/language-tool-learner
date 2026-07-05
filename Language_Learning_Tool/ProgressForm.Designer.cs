namespace Language_Learning_Tool
{
    partial class ProgressForm
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
            this.lblQuizzesTaken = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.lblFlashcards = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblGoalProgress = new System.Windows.Forms.Label();
            this.lblPracticed = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(555, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Session Progress";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuizzesTaken
            // 
            this.lblQuizzesTaken.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblQuizzesTaken.Location = new System.Drawing.Point(30, 100);
            this.lblQuizzesTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuizzesTaken.Name = "lblQuizzesTaken";
            this.lblQuizzesTaken.Size = new System.Drawing.Size(570, 34);
            this.lblQuizzesTaken.TabIndex = 1;
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblTotalQuestions.Location = new System.Drawing.Point(30, 138);
            this.lblTotalQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(570, 34);
            this.lblTotalQuestions.TabIndex = 2;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblCorrect.Location = new System.Drawing.Point(30, 177);
            this.lblCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(570, 34);
            this.lblCorrect.TabIndex = 3;
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgScore.Location = new System.Drawing.Point(30, 215);
            this.lblAvgScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(570, 34);
            this.lblAvgScore.TabIndex = 4;
            this.lblAvgScore.Click += new System.EventHandler(this.lblAvgScore_Click);
            // 
            // lblFlashcards
            // 
            this.lblFlashcards.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblFlashcards.Location = new System.Drawing.Point(30, 254);
            this.lblFlashcards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlashcards.Name = "lblFlashcards";
            this.lblFlashcards.Size = new System.Drawing.Size(570, 34);
            this.lblFlashcards.TabIndex = 5;
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(30, 300);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(555, 3);
            this.lblDivider.TabIndex = 6;
            // 
            // lblGoalProgress
            // 
            this.lblGoalProgress.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblGoalProgress.Location = new System.Drawing.Point(30, 315);
            this.lblGoalProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalProgress.Name = "lblGoalProgress";
            this.lblGoalProgress.Size = new System.Drawing.Size(570, 34);
            this.lblGoalProgress.TabIndex = 7;
            // 
            // lblPracticed
            // 
            this.lblPracticed.Font = new System.Drawing.Font("Courier New", 9.5F);
            this.lblPracticed.Location = new System.Drawing.Point(30, 354);
            this.lblPracticed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPracticed.Name = "lblPracticed";
            this.lblPracticed.Size = new System.Drawing.Size(570, 34);
            this.lblPracticed.TabIndex = 8;
            // 
            // btnReview
            // 
            this.btnReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReview.Location = new System.Drawing.Point(75, 423);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(300, 52);
            this.btnReview.TabIndex = 9;
            this.btnReview.Text = "Review Incorrect Answers";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(405, 423);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 52);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 508);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblQuizzesTaken);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.lblFlashcards);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblGoalProgress);
            this.Controls.Add(this.lblPracticed);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Progress";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuizzesTaken;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblFlashcards;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblGoalProgress;
        private System.Windows.Forms.Label lblPracticed;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnClose;
    }
}
