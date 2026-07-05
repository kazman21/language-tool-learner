namespace Language_Learning_Tool
{
    partial class QuizForm
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
            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryLabel
            // 
            this.lblCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategoryLabel.Location = new System.Drawing.Point(18, 23);
            this.lblCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryLabel.Name = "lblCategoryLabel";
            this.lblCategoryLabel.Size = new System.Drawing.Size(98, 34);
            this.lblCategoryLabel.TabIndex = 0;
            this.lblCategoryLabel.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.Location = new System.Drawing.Point(120, 18);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(298, 33);
            this.cmbCategory.TabIndex = 1;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartQuiz.Location = new System.Drawing.Point(442, 15);
            this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(150, 43);
            this.btnStartQuiz.TabIndex = 2;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuestionNumber.Location = new System.Drawing.Point(18, 85);
            this.lblQuestionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(750, 34);
            this.lblQuestionNumber.TabIndex = 3;
            this.lblQuestionNumber.Text = "Question 1 of 10";
            this.lblQuestionNumber.Click += new System.EventHandler(this.lblQuestionNumber_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(18, 126);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(750, 62);
            this.lblQuestion.TabIndex = 4;
            // 
            // radA
            // 
            this.radA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radA.Location = new System.Drawing.Point(30, 215);
            this.radA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(720, 46);
            this.radA.TabIndex = 5;
            this.radA.Text = "A)";
            // 
            // radB
            // 
            this.radB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radB.Location = new System.Drawing.Point(30, 274);
            this.radB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(720, 46);
            this.radB.TabIndex = 6;
            this.radB.Text = "B)";
            // 
            // radC
            // 
            this.radC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radC.Location = new System.Drawing.Point(30, 332);
            this.radC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(720, 46);
            this.radC.TabIndex = 7;
            this.radC.Text = "C)";
            // 
            // radD
            // 
            this.radD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radD.Location = new System.Drawing.Point(30, 391);
            this.radD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(720, 46);
            this.radD.TabIndex = 8;
            this.radD.Text = "D)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(255, 542);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(270, 55);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.Location = new System.Drawing.Point(255, 542);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(270, 55);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Question";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeedback.Location = new System.Drawing.Point(18, 458);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(750, 69);
            this.lblFeedback.TabIndex = 9;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 631);
            this.Controls.Add(this.lblCategoryLabel);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.radA);
            this.Controls.Add(this.radB);
            this.Controls.Add(this.radC);
            this.Controls.Add(this.radD);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take a Quiz";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblCategoryLabel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFeedback;
    }
}
