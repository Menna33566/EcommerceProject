namespace Ecommerce.PresentationV2
{
    partial class LoginForm
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
            labelUserEmail = new Label();
            labelPaswword = new Label();
            textEmail = new TextBox();
            textpassword = new TextBox();
            btnLogin = new Button();
            btnregister = new Button();
            SuspendLayout();
            // 
            // labelUserEmail
            // 
            labelUserEmail.AutoSize = true;
            labelUserEmail.Location = new Point(42, 109);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(79, 20);
            labelUserEmail.TabIndex = 0;
            labelUserEmail.Text = "User Email";
            // 
            // labelPaswword
            // 
            labelPaswword.AutoSize = true;
            labelPaswword.Location = new Point(42, 197);
            labelPaswword.Name = "labelPaswword";
            labelPaswword.Size = new Size(103, 20);
            labelPaswword.TabIndex = 1;
            labelPaswword.Text = "User Password";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(160, 106);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "User Email";
            textEmail.Size = new Size(291, 27);
            textEmail.TabIndex = 2;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(160, 194);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.PlaceholderText = "User Password";
            textpassword.Size = new Size(291, 27);
            textpassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Aquamarine;
            btnLogin.Location = new Point(193, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.FromArgb(128, 128, 255);
            btnregister.Location = new Point(193, 323);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(181, 53);
            btnregister.TabIndex = 5;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 407);
            Controls.Add(btnregister);
            Controls.Add(btnLogin);
            Controls.Add(textpassword);
            Controls.Add(textEmail);
            Controls.Add(labelPaswword);
            Controls.Add(labelUserEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserEmail;
        private Label labelPaswword;
        private TextBox textEmail;
        private TextBox textpassword;
        private Button btnLogin;
        private Button btnregister;
    }
}