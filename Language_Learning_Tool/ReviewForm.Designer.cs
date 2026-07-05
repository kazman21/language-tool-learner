namespace Language_Learning_Tool
{
    partial class ReviewForm
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
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvIncorrect = new System.Windows.Forms.DataGridView();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncorrect)).BeginInit();
            this.SuspendLayout();

            // lblNote
            this.lblNote.Text = "";
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNote.Location = new System.Drawing.Point(12, 12);
            this.lblNote.Size = new System.Drawing.Size(570, 24);

            // dgvIncorrect
            this.dgvIncorrect.Location = new System.Drawing.Point(12, 42);
            this.dgvIncorrect.Size = new System.Drawing.Size(570, 300);
            this.dgvIncorrect.ReadOnly = true;
            this.dgvIncorrect.AllowUserToAddRows = false;
            this.dgvIncorrect.AllowUserToDeleteRows = false;
            this.dgvIncorrect.RowHeadersVisible = false;
            this.dgvIncorrect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncorrect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncorrect.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIncorrect.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.colWord.Name = "colWord";
            this.colWord.HeaderText = "Word";
            this.colWord.FillWeight = 20;

            this.colMeaning.Name = "colMeaning";
            this.colMeaning.HeaderText = "Correct Meaning";
            this.colMeaning.FillWeight = 40;

            this.colExample.Name = "colExample";
            this.colExample.HeaderText = "Example Sentence";
            this.colExample.FillWeight = 40;

            this.dgvIncorrect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colWord, this.colMeaning, this.colExample
            });

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(252, 355);
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ReviewForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 402);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.dgvIncorrect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Incorrect Answers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncorrect)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvIncorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExample;
        private System.Windows.Forms.Button btnClose;
    }
}
