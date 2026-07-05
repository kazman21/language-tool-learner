namespace Language_Learning_Tool
{
    partial class FlashcardForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblCardFront = new System.Windows.Forms.Label();
            this.lblCardBack = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // lblCategoryLabel
            this.lblCategoryLabel.Text = "Category:";
            this.lblCategoryLabel.Location = new System.Drawing.Point(12, 15);
            this.lblCategoryLabel.Size = new System.Drawing.Size(65, 22);
            this.lblCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);

            // cmbCategory
            this.cmbCategory.Location = new System.Drawing.Point(80, 12);
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);

            // btnStart
            this.btnStart.Text = "Start Session";
            this.btnStart.Location = new System.Drawing.Point(295, 10);
            this.btnStart.Size = new System.Drawing.Size(110, 28);
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // lblProgress
            this.lblProgress.Text = "Select a category and press Start";
            this.lblProgress.Location = new System.Drawing.Point(12, 50);
            this.lblProgress.Size = new System.Drawing.Size(500, 22);
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProgress.ForeColor = System.Drawing.Color.DimGray;

            // pnlCard
            this.pnlCard.Location = new System.Drawing.Point(12, 78);
            this.pnlCard.Size = new System.Drawing.Size(500, 270);
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCard.Click += new System.EventHandler(this.pnlCard_Click);

            // lblCardFront
            this.lblCardFront.Text = "";
            this.lblCardFront.Location = new System.Drawing.Point(0, 0);
            this.lblCardFront.Size = new System.Drawing.Size(498, 268);
            this.lblCardFront.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCardFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCardBack
            this.lblCardBack.Text = "";
            this.lblCardBack.Location = new System.Drawing.Point(10, 10);
            this.lblCardBack.Size = new System.Drawing.Size(478, 248);
            this.lblCardBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCardBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardBack.Visible = false;

            this.pnlCard.Controls.Add(this.lblCardFront);
            this.pnlCard.Controls.Add(this.lblCardBack);

            // btnPrevious
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Location = new System.Drawing.Point(12, 362);
            this.btnPrevious.Size = new System.Drawing.Size(100, 34);
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);

            // btnFlip
            this.btnFlip.Text = "Flip Card";
            this.btnFlip.Location = new System.Drawing.Point(181, 362);
            this.btnFlip.Size = new System.Drawing.Size(160, 34);
            this.btnFlip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);

            // btnNext
            this.btnNext.Text = "Next";
            this.btnNext.Location = new System.Drawing.Point(412, 362);
            this.btnNext.Size = new System.Drawing.Size(100, 34);
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // FlashcardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 415);
            this.Controls.Add(this.lblCategoryLabel);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FlashcardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Flashcards";
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblCategoryLabel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblCardFront;
        private System.Windows.Forms.Label lblCardBack;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnNext;
    }
}
