namespace Ecommerce.PresentationV2
{
    partial class RegesterForm
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
            btnSignup = new Button();
            labelName = new Label();
            labelEmail = new Label();
            labelPass = new Label();
            labelAddress = new Label();
            textAddress = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            textName = new TextBox();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(176, 319);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(108, 48);
            btnSignup.TabIndex = 0;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 73);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 134);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(12, 187);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(72, 20);
            labelPass.TabIndex = 3;
            labelPass.Text = "PassWord";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(12, 247);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "Address";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(104, 244);
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "Address";
            textAddress.Size = new Size(226, 27);
            textAddress.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(104, 184);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(226, 27);
            textPassword.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(104, 131);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(226, 27);
            textEmail.TabIndex = 7;
            // 
            // textName
            // 
            textName.Location = new Point(104, 70);
            textName.Name = "textName";
            textName.PlaceholderText = "Name";
            textName.Size = new Size(226, 27);
            textName.TabIndex = 8;
            // 
            // RegesterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(textName);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textAddress);
            Controls.Add(labelAddress);
            Controls.Add(labelPass);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(btnSignup);
            Name = "RegesterForm";
            Text = "RegesterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignup;
        private Label labelName;
        private Label labelEmail;
        private Label labelPass;
        private Label labelAddress;
        private TextBox textAddress;
        private TextBox textPassword;
        private TextBox textEmail;
        private TextBox textName;
    }
}