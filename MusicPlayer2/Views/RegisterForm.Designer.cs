namespace MusicPlayer2
{
    partial class RegisterForm
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
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmText = new System.Windows.Forms.TextBox();
            this.RegistrateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(466, 55);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(238, 33);
            this.LoginText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(466, 106);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(238, 33);
            this.PasswordText.TabIndex = 1;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(466, 210);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(238, 33);
            this.FirstNameText.TabIndex = 2;
            // 
            // SecondNameText
            // 
            this.SecondNameText.Location = new System.Drawing.Point(466, 261);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(238, 33);
            this.SecondNameText.TabIndex = 3;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(382, 58);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(78, 26);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(373, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(87, 26);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(401, 213);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(59, 26);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(355, 264);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(105, 26);
            this.SecondNameLabel.TabIndex = 7;
            this.SecondNameLabel.Text = "Фамилия:";
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(251, 160);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(209, 26);
            this.PasswordConfirmLabel.TabIndex = 8;
            this.PasswordConfirmLabel.Text = "Подтвердите пароль:";
            // 
            // PasswordConfirmText
            // 
            this.PasswordConfirmText.Location = new System.Drawing.Point(466, 157);
            this.PasswordConfirmText.Name = "PasswordConfirmText";
            this.PasswordConfirmText.PasswordChar = '*';
            this.PasswordConfirmText.Size = new System.Drawing.Size(238, 33);
            this.PasswordConfirmText.TabIndex = 9;
            // 
            // RegistrateBtn
            // 
            this.RegistrateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrateBtn.Location = new System.Drawing.Point(466, 339);
            this.RegistrateBtn.Name = "RegistrateBtn";
            this.RegistrateBtn.Size = new System.Drawing.Size(238, 36);
            this.RegistrateBtn.TabIndex = 10;
            this.RegistrateBtn.Text = "Зарегистрироваться";
            this.RegistrateBtn.UseVisualStyleBackColor = true;
            this.RegistrateBtn.Click += new System.EventHandler(this.RegistrateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Location = new System.Drawing.Point(33, 53);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(125, 35);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegistrateBtn);
            this.Controls.Add(this.PasswordConfirmText);
            this.Controls.Add(this.PasswordConfirmLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SecondNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label PasswordConfirmLabel;
        private System.Windows.Forms.Button RegistrateBtn;
        private System.Windows.Forms.Button BackBtn;
        public System.Windows.Forms.TextBox LoginText;
        public System.Windows.Forms.TextBox PasswordText;
        public System.Windows.Forms.TextBox FirstNameText;
        public System.Windows.Forms.TextBox SecondNameText;
        public System.Windows.Forms.TextBox PasswordConfirmText;
    }
}