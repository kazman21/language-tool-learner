namespace Language_Learning_Tool
{
    partial class CategoryForm
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();

            this.grpAssign = new System.Windows.Forms.GroupBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.cmbAssignTo = new System.Windows.Forms.ComboBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.clbWords = new System.Windows.Forms.CheckedListBox();
            this.btnAssign = new System.Windows.Forms.Button();

            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.lblDeleteCategory = new System.Windows.Forms.Label();
            this.cmbDeleteCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();

            this.grpCreate.SuspendLayout();
            this.grpAssign.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.SuspendLayout();

            // grpCreate
            this.grpCreate.Text = "Create New Category";
            this.grpCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Size = new System.Drawing.Size(630, 65);

            this.lblNewCategory.Text = "Category name:";
            this.lblNewCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblNewCategory.Location = new System.Drawing.Point(10, 28);
            this.lblNewCategory.Size = new System.Drawing.Size(100, 22);

            this.txtNewCategory.Location = new System.Drawing.Point(115, 25);
            this.txtNewCategory.Size = new System.Drawing.Size(280, 23);
            this.txtNewCategory.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Location = new System.Drawing.Point(408, 23);
            this.btnAddCategory.Size = new System.Drawing.Size(115, 28);
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);

            this.grpCreate.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblNewCategory, this.txtNewCategory, this.btnAddCategory
            });

            // grpAssign
            this.grpAssign.Text = "Assign Words to Category";
            this.grpAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAssign.Location = new System.Drawing.Point(12, 88);
            this.grpAssign.Size = new System.Drawing.Size(630, 300);

            this.lblAssignTo.Text = "Assign selected words to:";
            this.lblAssignTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblAssignTo.Location = new System.Drawing.Point(10, 28);
            this.lblAssignTo.Size = new System.Drawing.Size(170, 22);

            this.cmbAssignTo.Location = new System.Drawing.Point(185, 25);
            this.cmbAssignTo.Size = new System.Drawing.Size(200, 23);
            this.cmbAssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignTo.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblWords.Text = "Check words to assign:";
            this.lblWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblWords.Location = new System.Drawing.Point(10, 58);
            this.lblWords.Size = new System.Drawing.Size(160, 22);

            this.clbWords.Location = new System.Drawing.Point(10, 82);
            this.clbWords.Size = new System.Drawing.Size(608, 170);
            this.clbWords.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clbWords.CheckOnClick = true;

            this.btnAssign.Text = "Assign Selected Words";
            this.btnAssign.Location = new System.Drawing.Point(215, 260);
            this.btnAssign.Size = new System.Drawing.Size(190, 30);
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            this.grpAssign.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblAssignTo, this.cmbAssignTo, this.lblWords, this.clbWords, this.btnAssign
            });

            // grpDelete
            this.grpDelete.Text = "Delete a Category";
            this.grpDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDelete.Location = new System.Drawing.Point(12, 400);
            this.grpDelete.Size = new System.Drawing.Size(630, 65);

            this.lblDeleteCategory.Text = "Category to delete:";
            this.lblDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblDeleteCategory.Location = new System.Drawing.Point(10, 28);
            this.lblDeleteCategory.Size = new System.Drawing.Size(125, 22);

            this.cmbDeleteCategory.Location = new System.Drawing.Point(140, 25);
            this.cmbDeleteCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbDeleteCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.Location = new System.Drawing.Point(355, 23);
            this.btnDeleteCategory.Size = new System.Drawing.Size(140, 28);
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);

            this.grpDelete.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblDeleteCategory, this.cmbDeleteCategory, this.btnDeleteCategory
            });

            // CategoryForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 482);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.grpAssign);
            this.Controls.Add(this.grpDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.grpCreate.ResumeLayout(false);
            this.grpAssign.ResumeLayout(false);
            this.grpDelete.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button btnAddCategory;

        private System.Windows.Forms.GroupBox grpAssign;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.ComboBox cmbAssignTo;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.CheckedListBox clbWords;
        private System.Windows.Forms.Button btnAssign;

        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Label lblDeleteCategory;
        private System.Windows.Forms.ComboBox cmbDeleteCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}
