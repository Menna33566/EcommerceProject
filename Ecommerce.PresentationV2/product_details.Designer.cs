namespace Ecommerce.PresentationV2
{
    partial class product_details
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
            pictureBox1 = new PictureBox();
            LB_Name = new Label();
            Description = new Label();
            Price = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LB_Name
            // 
            LB_Name.AutoSize = true;
            LB_Name.BackColor = SystemColors.HotTrack;
            LB_Name.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold | FontStyle.Italic);
            LB_Name.ForeColor = SystemColors.ButtonFace;
            LB_Name.Location = new Point(72, 354);
            LB_Name.Name = "LB_Name";
            LB_Name.Size = new Size(141, 65);
            LB_Name.TabIndex = 1;
            LB_Name.Text = "label1";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(476, 333);
            Description.Name = "Description";
            Description.Size = new Size(50, 20);
            Description.TabIndex = 2;
            Description.Text = "label1";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(685, 333);
            Price.Name = "Price";
            Price.Size = new Size(50, 20);
            Price.TabIndex = 3;
            Price.Text = "label1";
            // 
            // product_details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Price);
            Controls.Add(Description);
            Controls.Add(LB_Name);
            Controls.Add(pictureBox1);
            Name = "product_details";
            Text = "product_details";
            Load += product_details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LB_Name;
        private Label Description;
        private Label Price;
    }
}