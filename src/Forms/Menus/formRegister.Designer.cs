﻿namespace ChessMasterQuiz
{
    partial class formRegister
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            txtBoxEmail = new TextBox();
            txtBoxPassword = new TextBox();
            txtBoxDisplayName = new TextBox();
            btnRegister = new Button();
            txtBoxGender = new TextBox();
            txtBoxDob = new TextBox();
            progressPassword = new ProgressBar();
            pBoxLogo = new PictureBox();
            pBarUsername = new ProgressBar();
            pBarDisplayName = new ProgressBar();
            pBarGender = new ProgressBar();
            pBarDob = new ProgressBar();
            btnBack = new Button();
            toolTipPassword = new ToolTip(components);
            pBoxQuestionPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxQuestionPassword).BeginInit();
            SuspendLayout();
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.AcceptsReturn = true;
            txtBoxEmail.AcceptsTab = true;
            txtBoxEmail.BackColor = Color.White;
            txtBoxEmail.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(12, 16);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.PlaceholderText = "Username";
            txtBoxEmail.Size = new Size(268, 43);
            txtBoxEmail.TabIndex = 1;
            txtBoxEmail.Tag = "username";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.AcceptsReturn = true;
            txtBoxPassword.AcceptsTab = true;
            txtBoxPassword.BackColor = Color.White;
            txtBoxPassword.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(12, 81);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PlaceholderText = "Password";
            txtBoxPassword.Size = new Size(268, 43);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.Tag = "password";
            // 
            // txtBoxDisplayName
            // 
            txtBoxDisplayName.AcceptsReturn = true;
            txtBoxDisplayName.AcceptsTab = true;
            txtBoxDisplayName.BackColor = Color.White;
            txtBoxDisplayName.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDisplayName.Location = new Point(12, 146);
            txtBoxDisplayName.Name = "txtBoxDisplayName";
            txtBoxDisplayName.PlaceholderText = "Confirm Password";
            txtBoxDisplayName.Size = new Size(268, 43);
            txtBoxDisplayName.TabIndex = 3;
            txtBoxDisplayName.Tag = "password_confirm";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 255, 192);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(168, 357);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 63);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register!";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBoxGender
            // 
            txtBoxGender.AcceptsReturn = true;
            txtBoxGender.AcceptsTab = true;
            txtBoxGender.BackColor = Color.White;
            txtBoxGender.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxGender.Location = new Point(12, 211);
            txtBoxGender.Name = "txtBoxGender";
            txtBoxGender.PlaceholderText = "Email";
            txtBoxGender.Size = new Size(268, 43);
            txtBoxGender.TabIndex = 4;
            txtBoxGender.Tag = "email";
            // 
            // txtBoxDob
            // 
            txtBoxDob.AcceptsReturn = true;
            txtBoxDob.AcceptsTab = true;
            txtBoxDob.BackColor = Color.White;
            txtBoxDob.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDob.Location = new Point(12, 276);
            txtBoxDob.Name = "txtBoxDob";
            txtBoxDob.PlaceholderText = "DOB D/M/Y";
            txtBoxDob.Size = new Size(268, 43);
            txtBoxDob.TabIndex = 5;
            txtBoxDob.Tag = "dob";
            // 
            // progressPassword
            // 
            progressPassword.BackColor = Color.FromArgb(192, 255, 192);
            progressPassword.ForeColor = Color.FromArgb(192, 255, 192);
            progressPassword.Location = new Point(12, 130);
            progressPassword.Name = "progressPassword";
            progressPassword.Size = new Size(268, 10);
            progressPassword.TabIndex = 12;
            // 
            // pBoxLogo
            // 
            pBoxLogo.Location = new Point(360, 20);
            pBoxLogo.Name = "pBoxLogo";
            pBoxLogo.Size = new Size(400, 400);
            pBoxLogo.TabIndex = 13;
            pBoxLogo.TabStop = false;
            // 
            // pBarUsername
            // 
            pBarUsername.BackColor = Color.FromArgb(192, 255, 192);
            pBarUsername.ForeColor = Color.FromArgb(192, 255, 192);
            pBarUsername.Location = new Point(12, 65);
            pBarUsername.Name = "pBarUsername";
            pBarUsername.Size = new Size(268, 10);
            pBarUsername.TabIndex = 14;
            // 
            // pBarDisplayName
            // 
            pBarDisplayName.BackColor = Color.FromArgb(192, 255, 192);
            pBarDisplayName.ForeColor = Color.FromArgb(192, 255, 192);
            pBarDisplayName.Location = new Point(12, 195);
            pBarDisplayName.Name = "pBarDisplayName";
            pBarDisplayName.Size = new Size(268, 10);
            pBarDisplayName.TabIndex = 15;
            // 
            // pBarGender
            // 
            pBarGender.BackColor = Color.FromArgb(192, 255, 192);
            pBarGender.ForeColor = Color.FromArgb(192, 255, 192);
            pBarGender.Location = new Point(12, 260);
            pBarGender.Name = "pBarGender";
            pBarGender.Size = new Size(268, 10);
            pBarGender.TabIndex = 16;
            // 
            // pBarDob
            // 
            pBarDob.BackColor = Color.FromArgb(192, 255, 192);
            pBarDob.ForeColor = Color.FromArgb(192, 255, 192);
            pBarDob.Location = new Point(12, 325);
            pBarDob.Name = "pBarDob";
            pBarDob.Size = new Size(268, 10);
            pBarDob.TabIndex = 17;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 255, 192);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("JetBrains Mono", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(47, 357);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 63);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pBoxQuestionPassword
            // 
            pBoxQuestionPassword.BackColor = Color.White;
            pBoxQuestionPassword.Image = (Image)resources.GetObject("pBoxQuestionPassword.Image");
            pBoxQuestionPassword.Location = new Point(247, 89);
            pBoxQuestionPassword.Name = "pBoxQuestionPassword";
            pBoxQuestionPassword.Size = new Size(31, 29);
            pBoxQuestionPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxQuestionPassword.TabIndex = 18;
            pBoxQuestionPassword.TabStop = false;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pBoxQuestionPassword);
            Controls.Add(btnBack);
            Controls.Add(pBarDob);
            Controls.Add(pBarGender);
            Controls.Add(pBarDisplayName);
            Controls.Add(pBarUsername);
            Controls.Add(pBoxLogo);
            Controls.Add(progressPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtBoxDob);
            Controls.Add(txtBoxGender);
            Controls.Add(txtBoxDisplayName);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Name = "formRegister";
            Text = "formRegister";
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxQuestionPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxEmail;
        private TextBox txtBoxPassword;
        private TextBox txtBoxDisplayName;
        private Button btnRegister;
        private TextBox txtBoxGender;
        private TextBox txtBoxDob;
        private ProgressBar progressPassword;
        private PictureBox pBoxLogo;
        private ProgressBar pBarUsername;
        private ProgressBar pBarDisplayName;
        private ProgressBar pBarGender;
        private ProgressBar pBarDob;
        private Button btnBack;
        private ToolTip toolTipPassword;
        private PictureBox pBoxQuestionPassword;
    }
}