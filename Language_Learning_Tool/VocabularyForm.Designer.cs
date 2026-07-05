namespace Language_Learning_Tool
{
    partial class VocabularyForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvVocabulary = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabulary)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();

            // Search row
            this.lblSearch.Text = "Search:";
            this.lblSearch.Location = new System.Drawing.Point(10, 14);
            this.lblSearch.Size = new System.Drawing.Size(50, 22);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtSearch.Location = new System.Drawing.Point(62, 11);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblFilter.Text = "Category:";
            this.lblFilter.Location = new System.Drawing.Point(275, 14);
            this.lblFilter.Size = new System.Drawing.Size(60, 22);
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.cmbFilter.Location = new System.Drawing.Point(337, 11);
            this.cmbFilter.Size = new System.Drawing.Size(160, 23);
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(507, 9);
            this.btnClear.Size = new System.Drawing.Size(60, 26);
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // DataGridView
            this.dgvVocabulary.Location = new System.Drawing.Point(10, 45);
            this.dgvVocabulary.Size = new System.Drawing.Size(760, 340);
            this.dgvVocabulary.ReadOnly = true;
            this.dgvVocabulary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVocabulary.MultiSelect = false;
            this.dgvVocabulary.AllowUserToAddRows = false;
            this.dgvVocabulary.AllowUserToDeleteRows = false;
            this.dgvVocabulary.RowHeadersVisible = false;
            this.dgvVocabulary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVocabulary.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVocabulary.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.colId.Name = "colId";
            this.colId.HeaderText = "ID";
            this.colId.Visible = false;

            this.colWord.Name = "colWord";
            this.colWord.HeaderText = "Word";
            this.colWord.FillWeight = 20;

            this.colMeaning.Name = "colMeaning";
            this.colMeaning.HeaderText = "Meaning";
            this.colMeaning.FillWeight = 30;

            this.colExample.Name = "colExample";
            this.colExample.HeaderText = "Example Sentence";
            this.colExample.FillWeight = 35;

            this.colCategory.Name = "colCategory";
            this.colCategory.HeaderText = "Category";
            this.colCategory.FillWeight = 15;

            this.dgvVocabulary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId, this.colWord, this.colMeaning, this.colExample, this.colCategory
            });

            // Action buttons
            this.btnAdd.Text = "Add New Word";
            this.btnAdd.Location = new System.Drawing.Point(10, 395);
            this.btnAdd.Size = new System.Drawing.Size(120, 32);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.Location = new System.Drawing.Point(140, 395);
            this.btnEdit.Size = new System.Drawing.Size(110, 32);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Location = new System.Drawing.Point(260, 395);
            this.btnDelete.Size = new System.Drawing.Size(120, 32);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Edit panel
            this.pnlEdit.Location = new System.Drawing.Point(10, 435);
            this.pnlEdit.Size = new System.Drawing.Size(760, 145);
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Visible = false;

            this.lblPanelTitle.Text = "Add New Word";
            this.lblPanelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.Location = new System.Drawing.Point(8, 8);
            this.lblPanelTitle.Size = new System.Drawing.Size(200, 22);

            this.lblWord.Text = "Word:";
            this.lblWord.Location = new System.Drawing.Point(8, 38);
            this.lblWord.Size = new System.Drawing.Size(45, 20);
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtWord.Location = new System.Drawing.Point(55, 35);
            this.txtWord.Size = new System.Drawing.Size(150, 23);
            this.txtWord.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblCategory.Text = "Category:";
            this.lblCategory.Location = new System.Drawing.Point(215, 38);
            this.lblCategory.Size = new System.Drawing.Size(65, 20);
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtCategory.Location = new System.Drawing.Point(282, 35);
            this.txtCategory.Size = new System.Drawing.Size(150, 23);
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblMeaning.Text = "Meaning:";
            this.lblMeaning.Location = new System.Drawing.Point(8, 68);
            this.lblMeaning.Size = new System.Drawing.Size(58, 20);
            this.lblMeaning.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtMeaning.Location = new System.Drawing.Point(68, 65);
            this.txtMeaning.Size = new System.Drawing.Size(680, 23);
            this.txtMeaning.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblExample.Text = "Example:";
            this.lblExample.Location = new System.Drawing.Point(8, 98);
            this.lblExample.Size = new System.Drawing.Size(58, 20);
            this.lblExample.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtExample.Location = new System.Drawing.Point(68, 95);
            this.txtExample.Size = new System.Drawing.Size(560, 23);
            this.txtExample.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(638, 95);
            this.btnSave.Size = new System.Drawing.Size(55, 26);
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(698, 95);
            this.btnCancel.Size = new System.Drawing.Size(55, 26);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.pnlEdit.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblPanelTitle, this.lblWord, this.txtWord, this.lblCategory, this.txtCategory,
                this.lblMeaning, this.txtMeaning, this.lblExample, this.txtExample,
                this.btnSave, this.btnCancel
            });

            // VocabularyForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 590);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvVocabulary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VocabularyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vocabulary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabulary)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvVocabulary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExample;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
