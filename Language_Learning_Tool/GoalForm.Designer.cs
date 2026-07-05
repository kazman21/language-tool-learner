namespace Language_Learning_Tool
{
    partial class GoalForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Set Daily Learning Goal";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(310, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDescription
            this.lblDescription.Text = "Target number of words to practice per session:";
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(20, 68);
            this.lblDescription.Size = new System.Drawing.Size(310, 22);

            // numTarget
            this.numTarget.Location = new System.Drawing.Point(120, 98);
            this.numTarget.Size = new System.Drawing.Size(110, 23);
            this.numTarget.Minimum = 1;
            this.numTarget.Maximum = 200;
            this.numTarget.Value = 10;
            this.numTarget.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnSave
            this.btnSave.Text = "Save Goal";
            this.btnSave.Location = new System.Drawing.Point(60, 145);
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(185, 145);
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // GoalForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.numTarget);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Daily Goal";
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
