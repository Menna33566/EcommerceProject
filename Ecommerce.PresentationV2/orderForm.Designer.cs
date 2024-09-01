namespace Ecommerce.PresentationV2
{
    partial class orderForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 44);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 240, 219);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(121, 44);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 6;
            label3.Text = "ProductName";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 83, 148);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(80, 347);
            button1.Name = "button1";
            button1.Size = new Size(157, 43);
            button1.TabIndex = 7;
            button1.Text = "ChangeQuantity";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 83, 148);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(342, 347);
            button2.Name = "button2";
            button2.Size = new Size(103, 43);
            button2.TabIndex = 8;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 83, 148);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(589, 347);
            button3.Name = "button3";
            button3.Size = new Size(111, 43);
            button3.TabIndex = 9;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 258);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 11;
            label4.Text = "Enter the new quantity";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(166, 77, 121);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(433, 263);
            button4.Name = "button4";
            button4.Size = new Size(124, 46);
            button4.TabIndex = 12;
            button4.Text = "NextProdcut";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(166, 77, 121);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(621, 263);
            button5.Name = "button5";
            button5.Size = new Size(138, 46);
            button5.TabIndex = 13;
            button5.Text = "PreviousProduct";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // orderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 219);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "orderForm";
            Text = "orderForm";
            Load += orderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
        private Button button4;
        private Button button5;
        private TextBox textBox4;
    }
}