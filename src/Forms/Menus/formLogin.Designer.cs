﻿namespace ChessMasterQuiz
{
    partial class formLogin
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
            lblNewQuiz = new Label();
            lblLogin = new Label();
            btnRegister = new Button();
            txtBoxEmail = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            pBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblNewQuiz
            // 
            lblNewQuiz.AutoSize = true;
            lblNewQuiz.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewQuiz.Location = new Point(27, 325);
            lblNewQuiz.Name = "lblNewQuiz";
            lblNewQuiz.Size = new Size(271, 36);
            lblNewQuiz.TabIndex = 3;
            lblNewQuiz.Text = "New to the Quiz?";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("JetBrains Mono", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(105, 61);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(114, 43);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(67, 371);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(181, 50);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.AcceptsReturn = true;
            txtBoxEmail.AcceptsTab = true;
            txtBoxEmail.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(56, 125);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.PlaceholderText = "Username";
            txtBoxEmail.Size = new Size(222, 43);
            txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.AcceptsReturn = true;
            txtBoxPassword.AcceptsTab = true;
            txtBoxPassword.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(56, 174);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PlaceholderText = "Password";
            txtBoxPassword.Size = new Size(222, 43);
            txtBoxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(56, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(222, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pBoxLogo
            // 
            pBoxLogo.Location = new Point(353, 21);
            pBoxLogo.Name = "pBoxLogo";
            pBoxLogo.Size = new Size(400, 400);
            pBoxLogo.TabIndex = 6;
            pBoxLogo.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pBoxLogo);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblLogin);
            Controls.Add(lblNewQuiz);
            Name = "formLogin";
            Text = "Chess Master";
            Load += formLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewQuiz;
        private Label lblLogin;
        private Button btnRegister;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private PictureBox pBoxLogo;
    }
}