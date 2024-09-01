namespace Ecommerce.PresentationV2
{
    partial class AdminDashBord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labeladmin = new Label();
            gradeAdminview = new DataGridView();
            btncategory = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            labeladminname = new Label();
            btnsave = new Button();
            ((System.ComponentModel.ISupportInitialize)gradeAdminview).BeginInit();
            SuspendLayout();
            // 
            // labeladmin
            // 
            labeladmin.AutoSize = true;
            labeladmin.Font = new Font("Segoe UI", 17F);
            labeladmin.Location = new Point(12, 24);
            labeladmin.Name = "labeladmin";
            labeladmin.Size = new Size(107, 40);
            labeladmin.TabIndex = 0;
            labeladmin.Text = "Admin:";
            // 
            // gradeAdminview
            // 
            gradeAdminview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradeAdminview.Location = new Point(21, 78);
            gradeAdminview.Name = "gradeAdminview";
            gradeAdminview.RowHeadersWidth = 51;
            gradeAdminview.Size = new Size(958, 368);
            gradeAdminview.TabIndex = 1;
            // 
            // btncategory
            // 
            btncategory.Location = new Point(86, 501);
            btncategory.Name = "btncategory";
            btncategory.Size = new Size(94, 46);
            btncategory.TabIndex = 2;
            btncategory.Text = "Category";
            btncategory.UseVisualStyleBackColor = true;
            btncategory.Click += btncategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.MenuHighlight;
            btnProduct.Location = new Point(294, 501);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(103, 46);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GrayText;
            btnOrder.Location = new Point(525, 501);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(110, 46);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // labeladminname
            // 
            labeladminname.AutoSize = true;
            labeladminname.Font = new Font("Segoe UI", 17F);
            labeladminname.Location = new Point(113, 25);
            labeladminname.Name = "labeladminname";
            labeladminname.Size = new Size(0, 40);
            labeladminname.TabIndex = 5;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(764, 501);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 46);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // AdminDashBord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 598);
            Controls.Add(btnsave);
            Controls.Add(labeladminname);
            Controls.Add(btnOrder);
            Controls.Add(btnProduct);
            Controls.Add(btncategory);
            Controls.Add(gradeAdminview);
            Controls.Add(labeladmin);
            Name = "AdminDashBord";
            Text = "AdminDashBord";
            Load += AdminDashBord_Load;
            ((System.ComponentModel.ISupportInitialize)gradeAdminview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeladmin;
        private DataGridView gradeAdminview;
        private Button btncategory;
        private Button btnProduct;
        private Button btnOrder;
        private Label labeladminname;
        private Button btnsave;
    }
}