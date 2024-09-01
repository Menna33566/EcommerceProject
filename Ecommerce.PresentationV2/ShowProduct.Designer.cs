namespace Ecommerce.PresentationV2
{
    partial class ShowProduct
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Prevbtn = new Button();
            Nextbtn = new Button();
            comboBoxCategory = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(60, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 419);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Ravie", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(121, 2);
            label1.Name = "label1";
            label1.Size = new Size(760, 109);
            label1.TabIndex = 3;
            label1.Text = "Our Products";
            // 
            // Prevbtn
            // 
            Prevbtn.BackColor = Color.BurlyWood;
            Prevbtn.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Prevbtn.Location = new Point(924, 370);
            Prevbtn.Name = "Prevbtn";
            Prevbtn.Size = new Size(173, 75);
            Prevbtn.TabIndex = 4;
            Prevbtn.Text = "previous";
            Prevbtn.UseVisualStyleBackColor = false;
            Prevbtn.Click += Prevbtn_Click;
            // 
            // Nextbtn
            // 
            Nextbtn.BackColor = Color.BurlyWood;
            Nextbtn.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Nextbtn.ForeColor = SystemColors.ActiveCaptionText;
            Nextbtn.Location = new Point(924, 206);
            Nextbtn.Name = "Nextbtn";
            Nextbtn.Size = new Size(162, 75);
            Nextbtn.TabIndex = 5;
            Nextbtn.Text = "Next";
            Nextbtn.UseVisualStyleBackColor = false;
            Nextbtn.Click += Nextbtn_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI", 15F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(385, 589);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(233, 43);
            comboBoxCategory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(75, 577);
            label2.Name = "label2";
            label2.Size = new Size(271, 55);
            label2.TabIndex = 7;
            label2.Text = "CategoryName";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Viner Hand ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(673, 589);
            button1.Name = "button1";
            button1.Size = new Size(173, 54);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ShowProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 699);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBoxCategory);
            Controls.Add(Nextbtn);
            Controls.Add(Prevbtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ShowProduct";
            Text = "ShowProduct";
            Load += ShowProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        public Label label1;
        private Button Prevbtn;
        private Button Nextbtn;
        private ComboBox comboBoxCategory;
        private Label label2;
        private Button button1;
    }
}